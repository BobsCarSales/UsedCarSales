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


        private void InitializeDropDowns()
        {
            // Associate the event-handling method with the 
            // SelectedIndexChanged event.
            this.makeDropDown.SelectedValueChanged += new System.EventHandler(LoadModels);
        }

        public void InitializeForm(List<Make> makes)
        {
            makeDropDown.DisplayMember = "Id";
            makeDropDown.ValueMember = "Id";
            makeDropDown.DataSource = makes;

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

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (mode == ADD_VEHICLE)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.Model = (Model)modelDropDown.SelectedItem;
                vehicle.sold = soldCheckBox.Checked;
                vehicle.used = usedCheckBox.Checked;
                vehicle.year = DateUtil.HandleYearString(yearTextBox.Text.ToString());
                //TODO: we need to be checking that the price is the correct format
                vehicle.price = Decimal.Parse(priceTextBox.Text.ToString());

                if(vehicle.year != DateUtil.INVALID_YEAR)
                {
                    VehicleDAO.AddVehicle(vehicle);

                    //add the new vehicle to the list so it shows when the user goes back to the VehiclesForm
                    VehiclesForm vehiclesForm = (VehiclesForm)parentForm;
                    vehiclesForm.vehicles.Add(vehicle);

                    closeForm();
                } else
                {
                    MessageBox.Show("Please enter a valid year", "Invalid Year Value", MessageBoxButtons.OK);
                }
            }
            else if(mode == EDIT_VEHICLE)
            {
                CurrentVehicle.Model = (Model)modelDropDown.SelectedItem;
                CurrentVehicle.sold = soldCheckBox.Checked;
                CurrentVehicle.used = usedCheckBox.Checked;
                CurrentVehicle.year = DateUtil.HandleYearString(yearTextBox.Text.ToString());
                //TODO: we need to be checking that the price is the correct format
                CurrentVehicle.price = Decimal.Parse(priceTextBox.Text.ToString());

                if (CurrentVehicle.year != DateUtil.INVALID_YEAR)
                {
                    VehicleDAO.EditVehicle(CurrentVehicle);
                    closeForm();
                }
                else
                {
                    MessageBox.Show("Please enter a valid year", "Invalid Year Value", MessageBoxButtons.OK);
                }
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
