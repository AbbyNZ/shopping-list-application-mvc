using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;

namespace Assignment1B
{
    /// <summary>
	/// Summary description for AnyItem.
	/// </summary   
	public abstract class AnyItem
    {
        protected string itemName;
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        protected Color backColor;
        // added for hittest and highlight
        bool highlight;

        // constructor
        public AnyItem(string item, int x_at, int y_at, int itemWidth,
            int itemHeight, Color bkColor)
        {
            itemName = item;
            x = x_at;
            y = y_at;
            width = itemWidth;
            height = itemHeight;
            backColor = bkColor;
        }

        public abstract void Display(Graphics g); // abstract method

        public bool Highlight
        {
            get
            {
                return highlight;
            }
            set
            {
                highlight = value;
            }
        }

        public string Position()  //non abstract method
        {
            return "(" + x.ToString() + "," + y.ToString() + ")";
        }

        public abstract int x_pos //abstract property
        {
            get;
            set;
        }

        public abstract int y_pos //abstract property
        {
            get;
            set;
        }

        public abstract int item_width //abstract property
        {
            get;
            set;
        }

        public abstract int item_height //abstract property
        {
            get;
            set;
        }

        public abstract Color itemColor //abstract property
        {
            get;
            set;
        }

        public abstract string name //abstract property
        {
            get;
            set;
        }

        // virtual method
        public virtual bool HitTest(Point p)
        {
            Point pt = new Point(x, y);
            Size size = new Size(100, 100);
            //default behaviour
            return new Rectangle(pt, size).Contains(p);
        }
    }
}
