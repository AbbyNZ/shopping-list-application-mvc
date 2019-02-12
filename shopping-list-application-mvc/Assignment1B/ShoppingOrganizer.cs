/**
 * Author: Bernadette S. Batanes
 * Created: 22 October 2016
 **/

using System;
using System.Windows.Forms;

namespace Assignment1B
{
    /// <summary> Class : ShoppingOrganizer
    /// This program functions as a shopping organizer.
    /// The user is able to add list of items and as well as delete the items.
    /// This is the first class to be run.
    /// </summary>
     
    public partial class ShoppingOrganizer : Form
    {
        private ShoppingController theController;
        private Model model;
        private TextView frmTextView;
        private GraphicView frmGraphicView;
        private ReadOnlyView frmReadOnlyView;

        public ShoppingOrganizer()
        {
            InitializeComponent();
            theController = new ShoppingController();
            //Make model
            model = new Model(ref theController);
            //Make views
            frmTextView = new TextView(ref model);
            frmGraphicView = new GraphicView(ref model);
            frmReadOnlyView = new ReadOnlyView(ref model);
            
            theController.AddView(frmTextView);
            theController.AddView(frmGraphicView);
            theController.AddView(frmReadOnlyView);
        }
        
        private void btnTextView_Click(object sender, EventArgs e)
        {
           frmTextView.Show();
        }

        private void btnGraphicView_Click(object sender, EventArgs e)
        {
            frmGraphicView.Show();
        }

        private void btnReadView_Click(object sender, EventArgs e)
        {
            frmReadOnlyView.Show();
        }
    }
}
