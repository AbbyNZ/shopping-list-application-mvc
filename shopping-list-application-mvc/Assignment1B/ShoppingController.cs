using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1B
{
    public interface IShapeView
    {
        void RefreshView();
    }

    /// <summary>
	/// Summary description for ShoppingController.
	/// </summary>
    public class ShoppingController
    {
        private ArrayList ViewList;

        // constructor
        public ShoppingController()
        {
            ViewList = new ArrayList();
        }

        /// <summary>method: AddView
        /// add view to viewlist
        /// </summary>
        /// <param name="aView"></param>
        public void AddView(IShapeView aView)
        {
            ViewList.Add(aView);
        }

        /// <summary>method: UpdateViews
        /// update each view 
        /// </summary>
        public void UpdateViews()
        {
            IShapeView[] theViews = (IShapeView[])ViewList.ToArray(typeof(IShapeView));
            foreach (IShapeView v in theViews)
            {
                v.RefreshView();
            }
        }
    }
}
