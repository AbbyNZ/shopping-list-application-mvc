using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using System.Windows.Forms;

namespace Assignment1B
{
    public partial class GraphicView : Form, IShapeView
    {
        private Model model;
        BinaryFormatter binFor;

        bool dragging;
        AnyItem itemSelected;   //  variable for selected item      
        AnyItem editItem;

        // variables for mouse position
        Point lastPosition = new Point(0, 0);
        Point currentPosition = new Point(0, 0);

        public GraphicView(ref Model model)
        {
            InitializeComponent();
            this.model = model;
            pnlUpdate.Hide();

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

        /// <summary> method: btnAdd_Click_1
        /// adds item to the model based on existing parameters picked by the user
        /// </summary>

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AnyItem anItem;

            try
            {
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

                // if chicken is selected create the rectangle shape
                else if (rbChicken.Checked)
                {
                    anItem = new Meat("Chicken", 120, 0, 60, 50, Color.Pink);
                    model.AddItem(anItem);
                }

                // if beef is selected create the rectangle shape
                else if (rbBeef.Checked)
                {
                    anItem = new Meat("Beef", 120, 80, 60, 50, Color.Red);
                    model.AddItem(anItem);
                }

                // if pork is selected create the rectangle shape
                else if (rbPork.Checked)
                {
                    anItem = new Meat("Pork", 120, 180, 60, 50, Color.Blue);
                    model.AddItem(anItem);
                }

                // if fish is selected create the rectangle shape
                else if (rbFish.Checked)
                {
                    anItem = new Meat("Fish", 120, 260, 60, 50, Color.Yellow);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + "\r\n" + ex.ToString(),
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>method: pnlView__MouseDown
        /// check if mouse is over shape and sets sets variable to 
        /// enable shape to be moved
        /// </summary>
        private void pnlView__MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point mouseDownLocation = new Point(e.X, e.Y);

            if (itemSelected != null)
                dragging = true;
        }

        /// <summary>method: pnlView__MouseUp
        /// method to stop dragging of shape
        /// </summary>
        private void pnlView__MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dragging = false;
            // clear View panel
            clearPanel();
            // create arrayList of items from model and convert to array of items
            ArrayList theShoppingList = model.ShoppingList;
            AnyItem[] theItems = (AnyItem[])theShoppingList.ToArray(typeof(AnyItem));
            // graphics object to draw selected item
            Graphics g = this.pnlView.CreateGraphics();

            // check if item is selected and if so display
            if (itemSelected != null)
            {
                theItems[0] = itemSelected;
                itemSelected.Display(g);
            }
            model.UpdateViews();
        }

        /// <summary> method: pnlView_MouseMove
        /// when mouse moves it checks if mouse is down and/or over shape 
        /// If mouse is down and over shape, it draws border around shape and 
        /// sets new position for shape based on how far mouse has moved.
        /// If mouse is up and over shape, draw border around shape.
        /// If mouse if down and not over shape, do nothing.		
        /// </summary>
      
        private void pnlView_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // set last position to current position
            lastPosition = currentPosition;
            // set current position to mouse position
            currentPosition = new Point(e.X, e.Y);
            // calculate how far mouse has moved 
            int xMove = currentPosition.X - lastPosition.X;
            int yMove = currentPosition.Y - lastPosition.Y;

            if (!dragging) // mouse not down 
            {
                // reset variables 
                itemSelected = null;
                bool needsDisplay = false;

                // create arrayList of items from model
                ArrayList theShoppingList = model.ShoppingList;
                // create array of items from array list
                AnyItem[] theItems = (AnyItem[])theShoppingList.ToArray(typeof(AnyItem));
                // graphics object to draw items when required
                Graphics g = this.pnlView.CreateGraphics();

                //loop through array checking if mouse is over item
                foreach (AnyItem s in theItems)
                {
                    // check if mouse is over shape
                    if (s.HitTest(new Point(e.X, e.Y)))
                    {
                        // if so make item topItem
                        itemSelected = s;
                    }

                    if (s.Highlight == true)
                    {
                        // item to be redrawn
                        needsDisplay = true;
                        // redraw item
                        s.Display(g);
                        s.Highlight = false;
                    }

                }

                if (itemSelected != null) // if there is a topItem
                {
                    needsDisplay = true; // need to redisplay
                    itemSelected.Display(g); // redisplay topItem					
                    itemSelected.Highlight = true;
                }

                if (needsDisplay)
                {
                    // redisplay model
                    model.UpdateViews();
                }
            }
            else // mouse is down
            {
                // reset position of selected item by value of mouse move 
                itemSelected.x_pos = itemSelected.x_pos + xMove;
                itemSelected.y_pos = itemSelected.y_pos + yMove;

                model.UpdateViews();
            }
        }

        /// <summary>method: btnModiy_Click
        /// displays the update panel and prompts the user to change the colour
        /// </summary>
       
        private void btnModify_Click(object sender, EventArgs e)
        {
            // show update panel
            pnlUpdate.Show();

            if (itemSelected != null)
            {
                // make editItem the current itemSelected 
                editItem = itemSelected;

                // update the colour of the selected item using the colour palette 
                lblUpdateColour.BackColor = itemSelected.itemColor;

                //model.UpdateViews();

            }
            model.UpdateViews();
        }


        private void clearPanel()
        {
            pnlView.CreateGraphics().Clear(pnlView.BackColor);
        }


        /// <summary>method: btnDelete_Click
        /// delete selected shape and redisplay shapes remaining in model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // check if itemSelected has a value, if so delete
            if (itemSelected != null)
            {
                // clear panel
                clearPanel();
                // delete selected item and redisplay the remaining items
                model.DeleteItem(itemSelected);
            }
            model.UpdateViews();
        }

        private void mnuModify_Click(object sender, EventArgs e)
        {
            // show update panel
            pnlUpdate.Show();

            if (itemSelected != null)
            {
                // make editItem the current itemSelected 
                editItem = itemSelected;

                // update the colour of the selected item using the colour palette 
                lblUpdateColour.BackColor = itemSelected.itemColor;
                
            }
            model.UpdateViews();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            // check if itemSelected has a value, if so delete
            if (itemSelected != null)
            {
                // clear panel
                clearPanel();
                // delete selected item and redisplay the remaining items
                model.DeleteItem(itemSelected);
            }
            model.UpdateViews();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // clear draw on panel
            clearPanel();

            Color backColor;
            backColor = lblUpdateColour.BackColor;

            // update selected item
            editItem.itemColor = backColor;  //something is wrong with the backColor
            model.UpdateItem(itemSelected);

            // redisplay
            model.UpdateViews();
            pnlUpdate.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlUpdate.Hide();
        }

        /// <summary>method: lblNewBackColour_Click
        /// set lblUpdateColor to selected color
        /// </summary>
        private void lblNewBackColour_Click_1(object sender, EventArgs e)
        {
            lblUpdateColour.BackColor = (sender as Label).BackColor;
        }

        private void btnSaveGraphic_Click(object sender, EventArgs e)
        {
            //SaveFileDialog sd = new SaveFileDialog();
            //sd.Filter = "dat files | *.dat";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                FileInfo finfo = new FileInfo(saveFileDialog1.FileName);
                Stream strm;
                binFor = new BinaryFormatter();
                strm = finfo.Open(FileMode.Create, FileAccess.ReadWrite);
                ArrayList theShoppingList = model.ShoppingList;
                AnyItem[] theItems = (AnyItem[])theShoppingList.ToArray(typeof(AnyItem));
                foreach (AnyItem item in theItems)
                {
                    binFor.Serialize(strm, item);
                }
                strm.Close();
            }
        }
        /// <summary>method: reDisplay
        /// redraws all the shapes in the model
        /// </summary>
        public void reDisplay()
        {
            ArrayList theShoppingList = model.ShoppingList;
            AnyItem[] theItems = (AnyItem[])theShoppingList.ToArray(typeof(AnyItem));
            Graphics g = this.pnlView.CreateGraphics();
            foreach (AnyItem item in theItems)
            {
                item.Display(g);
            }
        }

        /// <summary>method: CheckForNumeric
		/// check for only numbers and backspace key
		/// </summary>
		/// <param name="ch"></param>
		/// <returns></returns>
		static bool CheckForNumeric(char ch)
        {
            int keyInt = (int)ch;
            if ((keyInt < 48 || keyInt > 57) && keyInt != 8)
                return false;
            else
                return true;
        }

        /// <summary> method: txtXpos_KeyPress
        /// allow only numbers and backspace key
        /// </summary>
        
        private void PersonalCare_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            
            if (CheckForNumeric(e.KeyChar) == false)
                e.Handled = true;
        }

        private void GraphicView_Load(object sender, EventArgs e)
        {
            //binFor = new BinaryFormatter();
        }

        private void rbFruits_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }

}
