using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UsedCarSales
{
    public partial class AddEditVehicleForm : Form
    {
        public const int ADD_VEHICLE = 0;
        public const int EDIT_VEHICLE = 1;

        ModelDatabaseHandler modelDatabaseHandler = ModelDatabaseHandler.Instance;
        VehicleDatabaseHandler vehicleDatabaseHandler = VehicleDatabaseHandler.Instance;

        Vehicle CurrentVehicle { get; set; }
        int mode;

        public AddEditVehicleForm(Vehicle vehicle, int mode, List<Make> makes)
        {
            this.CurrentVehicle = vehicle;
            this.mode = mode;

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
                if (CurrentVehicle.Model.Id != null) modelDropDown.SelectedItem = CurrentVehicle.Model.Id;
                if (CurrentVehicle.Used != null) usedCheckBox.Checked = (bool) CurrentVehicle.Used;
                if (CurrentVehicle.Sold != null) soldCheckBox.Checked = (bool) CurrentVehicle.Sold;
                if (CurrentVehicle.Year != null) yearTextBox.Text = CurrentVehicle.Year.ToString();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (mode == ADD_VEHICLE)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.Model = (Model)modelDropDown.SelectedItem;
                vehicle.Sold = soldCheckBox.Checked;
                vehicle.Used = usedCheckBox.Checked;
                vehicle.Year = Int32.Parse(yearTextBox.Text);

                vehicleDatabaseHandler.addVehicle(vehicle);
            }
            else if(mode == EDIT_VEHICLE)
            {
                CurrentVehicle.Model = (Model)modelDropDown.SelectedItem;
                CurrentVehicle.Sold = soldCheckBox.Checked;
                CurrentVehicle.Used = usedCheckBox.Checked;
                CurrentVehicle.Year = Int32.Parse(yearTextBox.Text);

                vehicleDatabaseHandler.editVehicle(CurrentVehicle);
            }

            this.Close();
        }

        //TODO: will be called everytime makeDropDown changes, need to move some of the init stuff out
        //TODO: this should not be called when form is loading. it currently is being called
        private void LoadModels(object sender, System.EventArgs e)
        {
            if (makeDropDown.SelectedItem != null)
            {
                List<Model> models = modelDatabaseHandler.GetModelByMakeId( ((Make)makeDropDown.SelectedItem).Id);

                modelDropDown.DisplayMember = "Id";
                modelDropDown.ValueMember = "Id";
                modelDropDown.DataSource = models;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
