using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Assignment1B
{
    /// <summary>
	/// Summary description for TextView.
	/// </summary>
    public partial class TextView : Form, IShapeView
    {
        private Model model;

        AnyItem itemSelected; //  variable for selected item

        public TextView(ref Model model)
        {
            InitializeComponent();
            this.model = model;
            pnlTextUpdate.Hide();
            // sets drawing style to remove blinking ***not working***			
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

       
        /// <summary> method: RefreshView
		/// clears the listBox display of all the items in the Model
		/// </summary>
		public void RefreshView()
        {
            // clear listBox
            listBox1.Items.Clear();
            // create arrayList from model and convert to array of items
            ArrayList theShoppingList = model.ShoppingList;
            AnyItem[] theItems = (AnyItem[])theShoppingList.ToArray(typeof(AnyItem));
            Graphics g = this.pnlView.CreateGraphics();
            // draw all items in array
            foreach (AnyItem item in theItems)
            {
                listBox1.Items.Add(item);
            }
        }

        /// <summary> method: btnAdd_Click
        /// adds item to the model based on existing parameters picked by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AnyItem anItem;

            // if fruits is selected create the circle shape
            if (rbFruits.Checked)
            {
                anItem = new Produce("Fruits", 0, 0, 50, 50, Color.Orange);
                model.AddItem(anItem);
            }

            //if vegetables is selected create the circle shape
            else if (rbVege.Checked)
            {
                anItem = new Produce("Vegetables", 0, 60, 50, 50, Color.Green);
                model.AddItem(anItem);
            }

            // if chicken is selected create the square shape
            else if (rbChicken.Checked)
            {
                anItem = new Meat("Chicken", 120, 0, 50, 50, Color.Pink);
                model.AddItem(anItem);
            }

            // if beef is selected create the rectangle shape
            else if (rbBeef.Checked)
            {
                anItem = new Meat("Beef", 120, 60, 60, 50, Color.Red);
                model.AddItem(anItem);
            }

            // if pork is selected create the rectangle shape
            else if (rbPork.Checked)
            {
                anItem = new Meat("Pork", 120, 120, 60, 50, Color.Blue);
                model.AddItem(anItem);
            }

            // if fish is selected create the rectangle shape
            else if (rbFish.Checked)
            {
                anItem = new Meat("Fish", 120, 190, 60, 50, Color.Yellow);
                model.AddItem(anItem);
            }

            // if shampoo is selected create the triangle shape
            else if (rbShampoo.Checked)
            {
                anItem = new PersonalCare("Shampoo", 250, 0, 60, 50, Color.Magenta);
                model.AddItem(anItem);
            }

            // if soap is selected create the triangle shape
            else if (rbSoap.Checked)
            {
                anItem = new PersonalCare("Soap", 250, 60, 60, 50, Color.Lavender);
                model.AddItem(anItem);
            }

            // if hand soap is selected create the triangle shape
            else if (rbHand.Checked)
            {
                anItem = new PersonalCare("Hand Soap", 250, 120, 60, 50, Color.LightBlue);
                model.AddItem(anItem);
            }

            //else // must be an ellipse
            //{
            //     anItem = new AnyElipse("elipse", X, Y, Width, Height, aColor);
            //     model.AddItem(anItem);
            //}
        }

        /// <summary>method: reDisplay
        /// redraws all the shapes in the model
        /// </summary>
        public void reDisplay()
        {
            ArrayList theShoppingList = model.ShoppingList;
            AnyItem[] theItems = (AnyItem[])theShoppingList.ToArray(typeof(AnyItem));
            Graphics g = this.pnlView.CreateGraphics();
            foreach (AnyItem sh in theItems)
            {
                sh.Display(g);
            }
        }

        /// <summary>method: btnDelete_Click
        /// delete selected item and redisplay remaining items in the model
        /// </summary>
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            ArrayList theShoppingList = model.ShoppingList;
            AnyItem[] theItems = (AnyItem[])theShoppingList.ToArray(typeof(AnyItem));
            foreach (AnyItem item in theItems)
            {
                if (listBox1.SelectedItem == item)
                {
                    model.DeleteItem(item);
                }
            }

            model.UpdateViews();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                ArrayList theShoppingList = model.ShoppingList;
                AnyItem[] theItems = (AnyItem[])theShoppingList.ToArray(typeof(AnyItem));
                foreach (AnyItem sh in theItems)
                {
                    sb.Append(sh.ToString());
                }
                string temp = sb.ToString();

                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(sb);
                sw.Close();
            }
        }

        private void TextView_Load(object sender, EventArgs e)
        {

        }

        /// <summary>method: btnModify_Click_1
        /// display the TextUpdate panel
        /// </summary>
        private void btnModify_Click_1(object sender, EventArgs e)
        {
            pnlTextUpdate.Show();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlTextUpdate.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem == itemSelected)
            {
                // update item colour
                lblUpdateColour.BackColor = itemSelected.itemColor;

            }
            //redisplay
            model.UpdateViews();

        }

        private void lblSelectColor_Click(object sender, EventArgs e)
        {
            lblUpdateColour.BackColor = (sender as Label).BackColor;
        }
    }

}
