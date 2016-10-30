using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsedCarSales.DataAccessObjects;

namespace UsedCarSales
{
    public partial class PromotionsForm : Form
    {
        public const int ADD_PROMOTION = 0;
        public const int EDIT_PROMOTION = 1;

        public PromotionsForm()
        {
            InitializeComponent();
        }

        //will only be called once when the VehiclesFrom loads
        private void initializeMakes()
        {
            List<Make> allMakes = MakeDAO.GetAllMakes();

            makeDropDownBox.DisplayMember = "id";
            makeDropDownBox.ValueMember = "id";
            makeDropDownBox.DataSource = allMakes;
        }

        //Theres no point in reloading the makes from the database in the AddEditPromotionForm, so we get them from the dropdowns that have already been loaded
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

        private void allPromotionsButton_Click(object sender, EventArgs e)
        {
            List<Promotion> promotions = PromotionDAO.GetAllPromotions();
            promotionsListBox.DataSource = promotions;
        }

        private void searchPromotionsButton_Click(object sender, EventArgs e)
        {
            List<Promotion> promotions = PromotionDAO.GetPromotionsByMake( (Make)makeDropDownBox.SelectedItem );
        }

        private void addPromotionsButton_Click(object sender, EventArgs e)
        {
            AddEditPromotionForm addPromotionForm = new AddEditPromotionForm(null, ADD_PROMOTION, getMakesList());
            addPromotionForm.Show();
        }

        private void editPromotionButton_Click(object sender, EventArgs e)
        {
            if(promotionsListBox.SelectedItem != null)
            {
                AddEditPromotionForm editPromotionForm = new AddEditPromotionForm((Promotion)promotionsListBox.SelectedItem, EDIT_PROMOTION, getMakesList());
                editPromotionForm.Show();

                //reset the list of promotions so old data doesn't hang out after we edit it
                promotionsListBox.DataSource = null;
            }
        }

        private void removePromotionButton_Click(object sender, EventArgs e)
        {

        }

    }
}
