using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment1B
{
    public partial class ReadOnlyView : Form, IShapeView
    {
        private Model model;

        public ReadOnlyView(ref Model model)
        {
            InitializeComponent();
            this.model = model;

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        public void RefreshView()
        {
            // clear View panel
            clearPanel();
            // create arrayList from model and convert to array of items
            ArrayList theShoppingList = model.ShoppingList;
            AnyItem[] theItems = (AnyItem[])theShoppingList.ToArray(typeof(AnyItem));
            Graphics g = this.pnlView.CreateGraphics();
            // draw all items in array
            foreach (AnyItem item in theItems)
            {
                item.Display(g);
            }
        }

        private void clearPanel()
        {
            pnlView.CreateGraphics().Clear(pnlView.BackColor);
        }

        /// <summary>method: DisplayCircles
		/// display circles only
		/// </summary>
		public void DisplayProduce()
        {
            // clear panel
            clearPanel();
            // create arraylist of shapes from model and convert
            // to array of shapes
            ArrayList theShoppingList = model.ShoppingList;
            AnyItem[] theItems = (AnyItem[])theShoppingList.ToArray(typeof(AnyItem));
            // graphics object to draw shapes
            Graphics g = this.pnlView.CreateGraphics();

            foreach (AnyItem sh in theItems)
            {
                // redraw Produce only
                if ((sh.name.Equals("Fruits")) || (sh.name.Equals("Vegetables")))
                    sh.Display(g);
            }
        }

        /// <summary>method: DisplayMeatFish
        /// display rectangles only
        /// </summary>
        public void DisplayMeatFish()
        {
            // clear panel
            clearPanel();
            // create arraylist of shapes from model and convert
            // to array of shapes
            ArrayList theShoppingList = model.ShoppingList;
            AnyItem[] theItems = (AnyItem[])theShoppingList.ToArray(typeof(AnyItem));
            // graphics object to draw shapes
            Graphics g = this.pnlView.CreateGraphics();

            foreach (AnyItem sh in theItems)
            {
                // only draw squares
                if ((sh.name.Equals("Chicken")) || (sh.name.Equals("Beef")) || (sh.name.Equals("Pork")) || (sh.name.Equals("Fish")))
                    sh.Display(g);
            }
        }

        /// <summary>method: DisplayPersonalCare
        ///  display personal care items only
        /// </summary>
        public void DisplayPersonalCare()
        {
            // clear panel
            clearPanel();
            // create arraylist of shapes from model and convert
            // to array of shapes
            ArrayList theShoppingList = model.ShoppingList;
            AnyItem[] theItems = (AnyItem[])theShoppingList.ToArray(typeof(AnyItem));
            // graphics object to draw shapes
            Graphics g = this.pnlView.CreateGraphics();

            foreach (AnyItem sh in theItems)
            {
                // only draw circles & squares
                if ((sh.name.Equals("Shampoo")) || (sh.name.Equals("Soap")) || (sh.name.Equals("Hand Soap")))
                    sh.Display(g);
            }
        }

        /// <summary>method: cmbFilterDisplay_SelectedIndexChanged work out which display method to execute based on 
		/// the value selected from combo box
		/// </summary>
        private void cmbFilterDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterDisplay.Text == "All Items")
                RefreshView();
            else if (cmbFilterDisplay.Text == "Produce only")
                DisplayProduce();
            else if (cmbFilterDisplay.Text == "Meat/Fish only")
                DisplayMeatFish();
            else if (cmbFilterDisplay.Text == "Personal Care only")
                DisplayPersonalCare();
        }

        private void ReadOnlyView_Load(object sender, EventArgs e)
        {
            cmbFilterDisplay.SelectedIndex = 0;
        }
    }
}
