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
            this.makeDropDownBox.SelectedIndexChanged += new System.EventHandler(LoadModels);
        }

        //will only be called once when the VehiclesFrom loads
        private void LoadMakes()
        {
            List<Make> allMakes = db.GetAllMakes();
            allMakes = allMakes.OrderBy(m => m.Name).ToList<Make>();

            makeDropDownBox.DisplayMember = "Name";
            makeDropDownBox.ValueMember = "Id";
            makeDropDownBox.DataSource = allMakes;

            //makeDropDownBox.SelectionChangeCommitted += (object sender, EventArgs e) => {
            //    Console.WriteLine("Selected Text:" + makeDropDownBox.SelectedText);
            //    Console.WriteLine("Selected Value:" + makeDropDownBox.SelectedValue.ToString());
            //};
        }

        //TODO: will be called everytime makeDropDown changes, need to move some of the init stuff out
        //TODO: this should not be called when form is loading. it currently is being called
        private void LoadModels(object sender, System.EventArgs e)
        {
            if(makeDropDownBox.SelectedItem != null)
            {
                //makeDropDownBox uses the Make's id as the value member
                //int selectedMakeId = (int)makeDropDownBox.SelectedItem;

                //List<Model> models = db.GetModelByMakeId(selectedMakeId);

                //modelDropDownBox.DisplayMember = "Name";
                //modelDropDownBox.ValueMember = "Id";
                //modelDropDownBox.DataSource = models;
            }
        }
    }
}
