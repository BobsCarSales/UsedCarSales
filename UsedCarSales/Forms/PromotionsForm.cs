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

        List<Promotion> promotions = new List<Promotion>();

        bool isSearch = false;

        public PromotionsForm()
        {
            InitializeComponent();

            initializeMakes();
            initializePromotionListBox();
        }

        //Initialize Promotions List box. Set up Event handlers and disable buttons that shouldn't be enabled if a promotion isn't selected
        private void initializePromotionListBox()
        {
            editPromotionButton.Enabled = false;
            removePromotionButton.Enabled = false;

            //when a promotion is selected or deselected, the edit promotion button needs to be enabled or disabled
            this.promotionsListBox.SelectedValueChanged += new System.EventHandler(initializeButtons);
        }

        //using this method because changeButtonEnabledValues is used in other places
        private void initializeButtons(object sender, System.EventArgs e)
        {
            changeButtonEnabledValues();
        }

        //change button enabled values depending on whether or not a promotion is selected
        private void changeButtonEnabledValues()
        {
            if (promotionsListBox.SelectedItem == null)
            {
                editPromotionButton.Enabled = false;
                removePromotionButton.Enabled = false;
            }
            else
            {
                editPromotionButton.Enabled = true;
                removePromotionButton.Enabled = true;
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

        //reload the promotions based on whether the user did a search last or loaded all promotions
        public void ReloadPromotions()
        {
            //reset the list of promotions so old data doesn't hang out after we edit it
            promotionsListBox.DataSource = null;

            if (isSearch)
            {
                searchPromotionsButton_Click();
            } else
            {
                allPromotionsButton_Click();
            }
        }

        //Get all promotions and update the list box
        private void allPromotionsButton_Click(object sender = null, EventArgs e = null)
        {
            isSearch = false;

            promotions = PromotionDAO.GetAllPromotions();
            updatePromotionsListBox(promotions);
        }

        private void searchPromotionsButton_Click(object sender = null, EventArgs e = null)
        {
            isSearch = true;

            promotions = PromotionDAO.GetPromotionsByMake( (Make)makeDropDownBox.SelectedItem );
            updatePromotionsListBox(promotions);
        }

        private void updatePromotionsListBox(List<Promotion> promotions)
        {
            promotionsListBox.DataSource = promotions;

            if (promotions.Count < 1)
            {
                changeButtonEnabledValues();
            }
        }

        private void addPromotionsButton_Click(object sender, EventArgs e)
        {
            AddEditPromotionForm addPromotionForm = new AddEditPromotionForm(null, ADD_PROMOTION, getMakesList(), this);
            addPromotionForm.Show();
        }

        private void editPromotionButton_Click(object sender, EventArgs e)
        {
            if(promotionsListBox.SelectedItem != null)
            {
                AddEditPromotionForm editPromotionForm = new AddEditPromotionForm((Promotion)promotionsListBox.SelectedItem, EDIT_PROMOTION, getMakesList(), this);
                editPromotionForm.Show();
            }
        }

        private void removePromotionButton_Click(object sender, EventArgs e)
        {
            //confirm deletion of the promotion
            var confirmResult = MessageBox.Show("Are you sure to delete this promotion?", "Confirm Deletion of Promotion", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                PromotionDAO.RemovePromotion((Promotion)promotionsListBox.SelectedItem);
                Promotion deletedPromotion = (Promotion)promotionsListBox.SelectedItem;
                promotions.Remove(deletedPromotion);

                promotionsListBox.DataSource = null;
                promotionsListBox.DataSource = promotions;

                Console.WriteLine("Promotion successfully deleted");
            }
        }

    }
}
