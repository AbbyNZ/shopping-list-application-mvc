using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment1B
{
    /// <summary>
	/// Summary description for Model.
	/// </summary>
	public class Model
    {
        private ArrayList shoppingList;                 //collection of data/shopping list
        private ShoppingController theController;
        private ArrayList produce;
        private ArrayList meat;
        private ArrayList personalCare;

        
        //Constructor
        public Model(ref ShoppingController aController)
        {
            shoppingList = new ArrayList();
            theController = aController;
            produce = new ArrayList();
            meat = new ArrayList();
            personalCare = new ArrayList();
        }

        /// <summary> property : ShoppingList
        /// A collection of data objects
        /// </summary>
        public ArrayList ShoppingList
        {
            get
            {
                return shoppingList;
            }
        }

        public ArrayList Produce
        {
            get
            {
                return produce;
            }
        }

        public ArrayList Meat
        {
            get
            {
                return meat;
            }

        }

        public ArrayList PersonalCare
        {
            get
            {
                return personalCare;
            }
        }

        /// <summary>method: AddShoppingList
        /// add shopping list to the model and update views
        /// </summary>
        /// <param name="anItem"></param>
        public void AddItem(AnyItem anItem)
        {
            shoppingList.Add(anItem);
            UpdateViews();
        }

        /// <summary>method: UpdateItem
        /// update views
        /// </summary>
        /// <param name="anItem"></param>
        public void UpdateItem(AnyItem anItem)
        {
            UpdateViews();
        }

        /// <summary>method: DeleteItem
        /// delete item and update views
        /// </summary>
        /// <param name="anItem"></param>
        public void DeleteItem(AnyItem anItem)
        {
            shoppingList.Remove(anItem);
            UpdateViews();
        }
        
        /// <summary>method: UpdateViews
        /// refresh all views
        /// </summary>
        public void UpdateViews()
        {
            theController.UpdateViews();
        }
    }
}
