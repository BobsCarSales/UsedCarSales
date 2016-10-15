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
        Database db;

        public Make selectedMake;
        public Model selectedModel;
        public bool used = false;
        public bool sold = false;

        public VehiclesForm()
        {
            db = Database.Instance;

            InitializeComponent();
            InitializeDropDowns();
            LoadMakes();
        }

        private void InitializeDropDowns()
        {
            // Associate the event-handling method with the 
            // SelectedIndexChanged event.
            this.makeDropDownBox.SelectedValueChanged += new System.EventHandler(LoadModels);
        }

        //will only be called once when the VehiclesFrom loads
        private void LoadMakes()
        {
            List<Make> allMakes = db.GetAllMakes();
            allMakes = allMakes.OrderBy(m => m.Name).ToList<Make>();

            makeDropDownBox.DisplayMember = "Name";
            makeDropDownBox.ValueMember = "Id";
            makeDropDownBox.DataSource = allMakes;
        }

        //TODO: will be called everytime makeDropDown changes, need to move some of the init stuff out
        //TODO: this should not be called when form is loading. it currently is being called
        private void LoadModels(object sender, System.EventArgs e)
        {
            if(makeDropDownBox.SelectedItem != null)
            {
                //makeDropDownBox uses the Make's id as the value member
                selectedMake = (Make)makeDropDownBox.SelectedItem;

                List<Model> models = db.GetModelByMakeId(selectedMake.Id);

                modelDropDownBox.DisplayMember = "Name";
                modelDropDownBox.ValueMember = "Id";
                modelDropDownBox.DataSource = models;
            }
        }

        private void searchVehicleButton_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();

            selectedModel = (Model)modelDropDownBox.SelectedItem;
            used = usedCheckBox.Checked;
            sold = usedCheckBox.Checked;

            vehicle.Model = selectedModel.Id;
            vehicle.Used = used;
            vehicle.Sold = sold;

            List<Vehicle> vehicles = db.searchVehicle(vehicle);

            vehiclesListBox.DisplayMember = "Id";
            vehiclesListBox.ValueMember = "Id";
            vehiclesListBox.DisplayMember = "Name";
            vehiclesListBox.ValueMember = "Name";
            vehiclesListBox.DataSource = vehicles;
        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            AddVehicleForm addVehicleForm = new AddVehicleForm();
            addVehicleForm.Show();
        }
    }
}
