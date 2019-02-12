using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1B
{
    /// <summary>
	/// Summary description for Produce.
	/// </summary>
    class Produce : AnyItem
    {
        // constructor
        public Produce(string itemName, int x_at, int y_at, int item_width,
            int item_height, Color bkColor)
			: base(itemName, x_at, y_at, item_width, item_height, bkColor)
        {

        }

        // override method to display shape as text
        public override string ToString()
        {
            return "Produce: " + itemName + " " + backColor;
        }

        // override method to display shape as graphics
        public override void Display(Graphics g)
        {
            if (g != null)
            {
                Brush br = new SolidBrush(backColor);
                g.FillEllipse(br, x, y, item_width, item_width);
            }

            // if shape needs border to be drawn
            if (Highlight)
            {
                // make slightly smaller than shape to avoid shadow
                float borderDiameter = (float)(item_width - 3);
                // draw border around circle
                Pen p = new Pen(Color.Black, 3);
                p.DashStyle = DashStyle.Solid;
                // to avoid shadow position move position by 1.5
                float xFloat = (float)(x + 1.5); float yFloat = (float)(y + 1.5);

                g.DrawEllipse(p, xFloat, yFloat, borderDiameter, borderDiameter);

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
        /// used to create ellipse the same size as the shape if selected
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public override bool HitTest(Point p)
        {
            GraphicsPath pth = new GraphicsPath();
            pth.AddEllipse(x, y, item_width, item_width);
            bool retval = pth.IsVisible(p);
            pth.Dispose();
            return retval;

        }
    }
}
