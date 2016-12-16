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

        public List<Vehicle> vehicles = new List<Vehicle>();

        //is the user searching for a certain vehicle or did the user load all of the vehicles at once
        bool isSearch = false;

        public VehiclesForm()
        {
            InitializeComponent();
            
            this.makeDropDownBox.SelectedValueChanged += new System.EventHandler(loadModels); //reload models when a new make is selected
            this.vehiclesListBox.SelectedValueChanged += new System.EventHandler(changeButtonEnabledValues); //when a vehicle is selected or deselected, the edit vehicle button needs to be enabled or disabled

            viewVehicleButton.Enabled = false;
            editVehicleButton.Enabled = false;
            removeVehicleButton.Enabled = false;
            sellVehicleButton.Enabled = false;

            initializeMakes();
        }

        //Reload vehicles list based on whether user previously searched or loaded all vehicles. Used when a new vehicle is added to the Vehicles table
        public void ReloadVehicles()
        {
            //reset the list of promotions so old data doesn't hang out after we edit it
            vehiclesListBox.DataSource = null;

            if (isSearch)
            {
                searchVehicleButton_Click();
            }
            else
            {
                allVehiclesButton_Click();
            }
        }

        //Update the vehicles list with the Vehicles in newVehiclesList
        private void updateVehiclesComboBox(List<Vehicle> newVehiclesList)
        {
            vehicles = newVehiclesList;
            vehiclesListBox.DataSource = vehicles;

            //If there are no vehicles, disable the buttons that rely on a Vehicle being selected
            if (vehicles.Count < 1)
            {
                changeButtonEnabledValues();
            }
        }

        //change button enabled values based on whether a Vehicle is selected when its called
        private void changeButtonEnabledValues(object sender = null, System.EventArgs e = null)
        {
            Boolean enabled = (vehiclesListBox.SelectedItem == null) ? false : true;

            editVehicleButton.Enabled = enabled;
            viewVehicleButton.Enabled = enabled;
            removeVehicleButton.Enabled = enabled;

            //only enable the Sell Vehicle button if the SelectedVehicle has not already been sold
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

        //Load models after a make has been selected. Only load Models that have the selected Make
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

        private void allVehiclesButton_Click(object sender = null, EventArgs e = null)
        {
            isSearch = false;
            updateVehiclesComboBox(VehicleDAO.GetAllVehicles());
        }

        private void searchVehicleButton_Click(object sender = null, EventArgs e = null)
        {
            isSearch = true;

            Vehicle vehicle = new Vehicle();

            //get the search criteria that the user input
            vehicle.Model = (Model)modelDropDownBox.SelectedItem;
            vehicle.used = usedCheckBox.Checked;
            vehicle.sold = soldCheckBox.Checked;
            vehicle.year = DateUtil.HandleYearString(yearTextBox.Text.ToString());

            //check if theres a minimum price to search by
            decimal? minPrice = null;
            if (!minPriceTextBox.Text.ToString().Equals("Min"))
            {
                minPrice = getDecimalPriceFromString(minPriceTextBox.Text.ToString());
            }

            //check if theres a maximum price to search by
            decimal? maxPrice = null;
            if (!maxPriceTextBox.Text.ToString().Equals("Max"))
            {
                maxPrice = getDecimalPriceFromString(maxPriceTextBox.Text.ToString());
            }

            updateVehiclesComboBox(VehicleDAO.SearchVehicles(vehicle, minPrice, maxPrice));
        }

        //seperate method for this so that the other methods that do this don't get cluttered
        private decimal? getDecimalPriceFromString(string text)
        {
            decimal? price = null;
            try
            {
                price = decimal.Parse(text);
            } catch
            {
                Console.WriteLine("Exception parsing price text box");
                price = null;
            }

            return price;
        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            AddEditVehicleForm addVehicleForm = new AddEditVehicleForm(null, ADD_VEHICLE, getMakesList(), this);
            addVehicleForm.Show();
        }

        private void editVehicleButton_Click(object sender, EventArgs e)
        {
            if(vehiclesListBox.SelectedItem != null)
            {
                AddEditVehicleForm editVehicleForm = new AddEditVehicleForm((Vehicle)vehiclesListBox.SelectedItem, EDIT_VEHICLE, getMakesList(), this);
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
                TransactionForm sellVehicleForm = new TransactionForm(selectedVehicle, this);
                sellVehicleForm.Show();
            }
        }
    }
}
