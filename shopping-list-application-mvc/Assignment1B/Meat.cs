using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1B
{
    class Meat : AnyItem
    {
        //Constructor
        public Meat(string itemName, int x_at, int y_at, int itemWidth, int itemHeight, Color bkColor) : base(itemName, x_at, y_at, itemWidth, itemHeight, bkColor)
        {

        }

        // override method to display shape as text
        public override string ToString()
        {
            return "Meat/Fish: " + itemName + " " + backColor;
        }

        // override method to display shape as graphics
        public override void Display(Graphics g)
        {
            if (g != null)
            {
                Brush br = new SolidBrush(backColor);
                g.FillRectangle(br, x, y, item_width, item_width);
                br.Dispose();
            }

            if (Highlight)
            {
                // add in border if shape selected
                // to define point and size
                Point pt = new Point(x + 1, y + 1); // to avoid shadow

                int borderSide = item_width - 3; // make slightly smaller than shape to avoid shadow
                Size size = new Size(borderSide, borderSide);
                // draw border
                Pen p = new Pen(Color.Black, 3);
                p.DashStyle = DashStyle.Solid;
                g.DrawRectangle(p, new Rectangle(pt, size));

                p.Dispose();
            }
        }

        public override int x_pos //non abstract property
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public override int y_pos //non abstract property
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public override int item_width //non abstract property
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public override int item_height //non abstract property
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public override Color itemColor //non abstract property
        {
            get
            {
                return backColor;
            }
            set
            {
                backColor = value;
            }
        }

        public override string name //non abstract property
        {
            get
            {
                return itemName;
            }
            set
            {
                itemName = value;
            }
        }

        /// <summary>method: HitTest
        /// used to create rectangle the same size as the shape if selected
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public override bool HitTest(Point p)
        {
            GraphicsPath pth = new GraphicsPath();
            pth.AddRectangle(new Rectangle(x, y, item_width, item_width));
            bool retval = pth.IsVisible(p);
            pth.Dispose();
            return retval;
        }
    }
}
