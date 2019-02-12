using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1B
{
    class PersonalCare : AnyItem
    {
        //Constructor
        public PersonalCare(string itemName, int x_at, int y_at, int itemWidth, int itemHeight, Color bkColor) : base(itemName, x_at, y_at, itemWidth, itemHeight, bkColor)
        {

        }

        // override method to display shape as text
        public override string ToString()
        {
            return "Personal Care: " + itemName + " " + backColor;
        }

        // override method to display shape as graphic
        public override void Display(Graphics g)
        {
            if (g != null)
            {
                // set points of triangle
                Point pt1 = new Point(x, y);
                Point pt2 = new Point(x, item_height + y);
                Point pt3 = new Point(item_width + x, y);

                Point[] points = { pt1, pt2, pt3 };

                Brush br = new SolidBrush(backColor);
                // create triangle (polygon with three points)
                g.FillPolygon(br, points);
            }

            if (Highlight)
            {
                // add in border if shape selected
                // to define point and size
                int x2 = x + 1;
                int y2 = y + 1;
                int height2 = item_height - 3;
                int width2 = item_width - 4;

                Point pt1a = new Point(x2, y2);
                Point pt2a = new Point(x2, height2 + y2);
                Point pt3a = new Point(width2 + x2, y2);

                Point[] points2 = { pt1a, pt2a, pt3a };
                // draw border
                Pen p = new Pen(Color.Black, 3);
                p.DashStyle = DashStyle.Solid;
                g.DrawPolygon(p, points2);

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

        public override int item_width  //non abstract property
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

        public override string name
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
        /// used to create polygon the same size as the shape if selected
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public override bool HitTest(Point p)
        {
            GraphicsPath pth = new GraphicsPath();

            Point pt1 = new Point(x, y);
            Point pt2 = new Point(x, height + y);
            Point pt3 = new Point(width + x, y);

            Point[] points = { pt1, pt2, pt3 };

            pth.AddPolygon(points);

            bool retval = pth.IsVisible(p);
            pth.Dispose();
            return retval;
        }
    }
}
