using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UsedCarSales.DataAccessObjects;

namespace UsedCarSales
{
    public partial class VehiclesForm : Form
    {
        public const int ADD_VEHICLE = 0;
        public const int EDIT_VEHICLE = 1;

        List<Vehicle> vehicles = new List<Vehicle>();

        public VehiclesForm()
        {
            InitializeComponent();
            
            this.makeDropDownBox.SelectedValueChanged += new System.EventHandler(loadModels); //reload models when a new make is selected
            this.vehiclesListBox.SelectedValueChanged += new System.EventHandler(changeButtonEnabledValues); //when a vehicle is selected or deselected, the edit vehicle button needs to be enabled or disabled

            viewVehicleButton.Enabled = false;
            editVehicleButton.Enabled = false;
            removeVehicleButton.Enabled = false;

            initializeMakes();
        }
        
        private void changeButtonEnabledValues(object sender = null, System.EventArgs e = null)
        {
            Boolean enabled = (vehiclesListBox.SelectedItem == null) ? false : true;

            editVehicleButton.Enabled = enabled;
            viewVehicleButton.Enabled = enabled;
            removeVehicleButton.Enabled = enabled;

            Vehicle vehicle = (Vehicle) vehiclesListBox.SelectedItem;
            if(vehicle != null)
            {
                if(vehicle.sold == true)
                {
                    sellVehicleButton.Enabled = false;
                } else
                {
                    sellVehicleButton.Enabled = true;
                }
            }
        }

        //will only be called once when the VehiclesFrom loads
        private void initializeMakes()
        {
            List<Make> allMakes = MakeDAO.GetAllMakes();

            makeDropDownBox.DisplayMember = "id";
            makeDropDownBox.ValueMember = "id";
            makeDropDownBox.DataSource = allMakes;
        }

        //TODO: will be called everytime makeDropDown changes, need to move some of the init stuff out
        //TODO: this should not be called when form is loading. it currently is being called
        private void loadModels(object sender, System.EventArgs e)
        {
            if(makeDropDownBox.SelectedItem != null)
            {
                Make selectedMake = (Make)makeDropDownBox.SelectedItem;
                List<Model> models = ModelDAO.GetModelsByMake(selectedMake);

                modelDropDownBox.DisplayMember = "id";
                modelDropDownBox.ValueMember = "id";
                modelDropDownBox.DataSource = models;
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

        private void allVehiclesButton_Click(object sender, EventArgs e)
        {
            vehicles = VehicleDAO.GetAllVehicles();
            vehiclesListBox.DataSource = vehicles;

            if(vehicles.Count < 1)
            {
                changeButtonEnabledValues();
            }
        }

        private void searchVehicleButton_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.Model = (Model)modelDropDownBox.SelectedItem;
            vehicle.used = usedCheckBox.Checked;
            vehicle.sold = soldCheckBox.Checked;
            vehicle.year = DateUtil.HandleYearString(yearTextBox.Text.ToString());

            vehicles = VehicleDAO.SearchVehicles(vehicle);
            vehiclesListBox.DataSource = vehicles;

            if(vehicles.Count < 1)
            {
                changeButtonEnabledValues();
            }
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

                //reset the list of vehicles so old data doesn't hang out after we edit it
                vehiclesListBox.DataSource = null;
            }
        }

        private void removeVehicle_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this vehicle?", "Confirm Deletion of Vehicle", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                VehicleDAO.RemoveVehicle((Vehicle) vehiclesListBox.SelectedItem);
                Vehicle deletedVehicle = (Vehicle) vehiclesListBox.SelectedItem;
                vehicles.Remove(deletedVehicle);

                vehiclesListBox.DataSource = null;
                vehiclesListBox.DataSource = vehicles;

                Console.WriteLine("Vehicle successfully deleted");
            }
        }

        private void viewVehicleButton_Click(object sender, EventArgs e)
        {
            if (vehiclesListBox.SelectedItem != null)
            {
                ViewVehicleForm viewVehicleForm = new ViewVehicleForm((Vehicle)vehiclesListBox.SelectedItem);
                viewVehicleForm.Show();
            }
        }

        private void sellVehicleButton_Click(object sender, EventArgs e)
        {
            Vehicle selectedVehicle = (Vehicle) vehiclesListBox.SelectedItem;
            if (selectedVehicle != null && selectedVehicle.sold != true)
            {
                TransactionForm sellVehicleForm = new TransactionForm(selectedVehicle);
                sellVehicleForm.Show();
            }
        }
    }
}
