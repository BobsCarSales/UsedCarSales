using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsedCarSales
{
    public partial class VehiclesForm : Form
    {
        public const int ADD_VEHICLE = 0;
        public const int EDIT_VEHICLE = 1;

        MakeDatabaseHandler makeDatabaseHandler = MakeDatabaseHandler.Instance;
        VehicleDatabaseHandler vehicleDatabaseHandler = VehicleDatabaseHandler.Instance;
        ModelDatabaseHandler modelDatabaseHandler = ModelDatabaseHandler.Instance;

        public VehiclesForm()
        {
            InitializeComponent();

            initializeDropDowns();
            loadMakes();
        }

        private void initializeDropDowns()
        {
            // Associate the event-handling method with the 
            // SelectedIndexChanged event.
            this.makeDropDownBox.SelectedValueChanged += new System.EventHandler(loadModels);
        }

        private void initializeVehicleListBox()
        {
            //when a vehicle is selected or deselected, the edit vehicle button needs to be enabled or disabled
            this.vehiclesListBox.SelectedValueChanged += new System.EventHandler(initializeEditVehicleButton);
        }

        //will only be called once when the VehiclesFrom loads
        private void loadMakes()
        {
            List<Make> allMakes = makeDatabaseHandler.GetAllMakes();
            allMakes = allMakes.OrderBy(m => m.Id).ToList<Make>();

            makeDropDownBox.DisplayMember = "Id";
            makeDropDownBox.ValueMember = "Id";
            makeDropDownBox.DataSource = allMakes;
        }

        //TODO: will be called everytime makeDropDown changes, need to move some of the init stuff out
        //TODO: this should not be called when form is loading. it currently is being called
        private void loadModels(object sender, System.EventArgs e)
        {
            if(makeDropDownBox.SelectedItem != null)
            {

                List<Model> models = modelDatabaseHandler.GetModelByMakeId( ((Make)makeDropDownBox.SelectedItem).Id);

                modelDropDownBox.DisplayMember = "Id";
                modelDropDownBox.ValueMember = "Id";
                modelDropDownBox.DataSource = models;
            }
        }

        //TODO: NOT WORKING YET
        //Enable or Disable the EditVehicleButton based on whether a vehicle is selected or not
        private void initializeEditVehicleButton(object sender, System.EventArgs e)
        {
            if(vehiclesListBox.SelectedItem == null)
            {
                editVehicleButton.Enabled = false;
                viewVehicleButton.Enabled = false;
            }
            else
            {
                editVehicleButton.Enabled = true;
                viewVehicleButton.Enabled = true;
            }
        }

        //Theres no point in reloading the makes and models from the database in the AddEditVehicleForm, so we get them from the dropdowns that have already been loaded
        //as far as I know theres no way to cast ComboBox.ObjectCollection to a List, so here we are
        //I could pass the ComboBox.ObjectCollection, but I can't set the dataSource of the other drop down that way (not sure why)
        private List<Make> getMakesList()
        {
            List<Make> itemList = new List<Make>();

            foreach (Make item in makeDropDownBox.Items)
            {
                itemList.Add(item);
            }

            return itemList;
        }

        private void searchVehicleButton_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.Model = (Model)modelDropDownBox.SelectedItem;
            vehicle.Used = usedCheckBox.Checked;
            vehicle.Sold = soldCheckBox.Checked;

            List<Vehicle> vehicles = vehicleDatabaseHandler.searchVehicle(vehicle);

            foreach(Vehicle v in vehicles) {
                v.Model = modelDatabaseHandler.GetModelById(v.Model.Id);
            }

            vehiclesListBox.DataSource = vehicles;
        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            AddEditVehicleForm addVehicleForm = new AddEditVehicleForm(null, ADD_VEHICLE, getMakesList());
            addVehicleForm.Show();
        }

        private void editVehicleButton_Click(object sender, EventArgs e)
        {
            if(vehiclesListBox.SelectedItem != null)
            {
                AddEditVehicleForm editVehicleForm = new AddEditVehicleForm((Vehicle)vehiclesListBox.SelectedItem, EDIT_VEHICLE, getMakesList());
                editVehicleForm.Show();
            }
        }
    }
}
