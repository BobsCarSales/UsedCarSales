using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UsedCarSales.DataAccessObjects;

namespace UsedCarSales
{
    public partial class AddEditVehicleForm : Form
    {
        public const int ADD_VEHICLE = 0;
        public const int EDIT_VEHICLE = 1;

        Vehicle CurrentVehicle { get; set; }
        int mode;
        Form parentForm;

        public AddEditVehicleForm(Vehicle vehicle, int mode, List<Make> makes, Form parentForm)
        {
            this.CurrentVehicle = vehicle;
            this.mode = mode;
            this.parentForm = parentForm;

            InitializeComponent();
            InitializeDropDowns();
            InitializeForm(makes);
        }

        //initialize the Models drop down
        private void InitializeDropDowns()
        {
            // Associate the event-handling method with the 
            // SelectedIndexChanged event.
            this.makeDropDown.SelectedValueChanged += new System.EventHandler(LoadModels);
        }

        public void InitializeForm(List<Make> makes)
        {
            //INitialize the Makes drop down with the makes passed from the VehiclesForm
            makeDropDown.DisplayMember = "Id";
            makeDropDown.ValueMember = "Id";
            makeDropDown.DataSource = makes;

            //if we're editing, fill in all of the text fields with information from the Vehicle we're editing
            if (CurrentVehicle != null)
            {
                if (CurrentVehicle.Model.Make != null) makeDropDown.SelectedItem = CurrentVehicle.Model.Make;
                if (CurrentVehicle.Model.id != null) modelDropDown.SelectedItem = CurrentVehicle.Model.id;
                if (CurrentVehicle.used != null) usedCheckBox.Checked = (bool) CurrentVehicle.used;
                if (CurrentVehicle.sold != null) soldCheckBox.Checked = (bool) CurrentVehicle.sold;
                if (CurrentVehicle.year != -1) yearTextBox.Text = CurrentVehicle.year.ToString();
                if (CurrentVehicle.price != -1) priceTextBox.Text = CurrentVehicle.price.ToString(); 
            }
        }

        //confirm that we're ready to save the Vehicle we're editing/adding
        private void confirmButton_Click(object sender, EventArgs e)
        {
            decimal price;
            try
            {
                price = Decimal.Parse(priceTextBox.Text.ToString());

                if(price > 0)
                {
                    //if adding
                    if (mode == ADD_VEHICLE)
                    {
                        //create the Vehicle object
                        Vehicle vehicle = new Vehicle();
                        vehicle.Model = (Model)modelDropDown.SelectedItem;
                        vehicle.sold = soldCheckBox.Checked;
                        vehicle.used = usedCheckBox.Checked;
                        vehicle.year = DateUtil.HandleYearString(yearTextBox.Text.ToString());
                        vehicle.price = price;

                        //check that the user hasn't entered an invalid year
                        if (vehicle.year != DateUtil.INVALID_YEAR)
                        {
                            //save the vehicle
                            VehicleDAO.AddVehicle(vehicle);

                            //add the new vehicle to the list so it shows when the user goes back to the VehiclesForm
                            VehiclesForm vehiclesForm = (VehiclesForm)parentForm;
                            vehiclesForm.vehicles.Add(vehicle);

                            closeForm();
                        }
                        else
                        {
                            //if the date is invalid, ask the user to enter it again without saving the vehicle
                            MessageBox.Show("Please enter a valid year", "Invalid Year Value", MessageBoxButtons.OK);
                        }
                    }
                    else if (mode == EDIT_VEHICLE)
                    {
                        //reassign all of the fields of the current Vehicle object with the information the user entered
                        CurrentVehicle.Model = (Model)modelDropDown.SelectedItem;
                        CurrentVehicle.sold = soldCheckBox.Checked;
                        CurrentVehicle.used = usedCheckBox.Checked;
                        CurrentVehicle.year = DateUtil.HandleYearString(yearTextBox.Text.ToString());
                        CurrentVehicle.price = price;

                        //make sure an invalid year isn't entered
                        if (CurrentVehicle.year != DateUtil.INVALID_YEAR)
                        {
                            //update the vehicle in the database
                            VehicleDAO.EditVehicle(CurrentVehicle);
                            closeForm();
                        }
                        else
                        {
                            //if the date is invalid, ask the user to enter it again without saving the vehicle
                            MessageBox.Show("Please enter a valid year", "Invalid Year Value", MessageBoxButtons.OK);
                        }
                    }
                } else
                {
                    MessageBox.Show("Invalid Price", "Invalid Price", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input", "Invalid Input", MessageBoxButtons.OK);
            }
        }

        //TODO: will be called everytime makeDropDown changes, need to move some of the init stuff out
        //TODO: this should not be called when form is loading. it currently is being called
        private void LoadModels(object sender, System.EventArgs e)
        {
            if (makeDropDown.SelectedItem != null)
            {
                Make make = (Make)makeDropDown.SelectedItem;
                List<Model> models = ModelDAO.GetModelsByMake(make);

                modelDropDown.DisplayMember = "Id";
                modelDropDown.ValueMember = "Id";
                modelDropDown.DataSource = models;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //will not be called if action is cancelled -- only if a save occurs
        private void closeForm()
        {
            VehiclesForm vehiclesForm = (VehiclesForm)parentForm;
            vehiclesForm.ReloadVehicles();

            this.Close();
        }
    }
}
