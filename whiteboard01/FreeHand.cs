using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace whiteboard01
{
    [Serializable]
    internal class FreeHand : Shape
    {

        //DataMember 
        private readonly ArrayList _points = new ArrayList();

        // counstractor 
        internal FreeHand(int x , int y,Color c, float width) : base(c,width) { Update(x, y); }
       
        // Metods 
        internal override void Draw(Graphics g)
        {
           

            for (int i = 0; i < this._points.Count - 1; i++)
            {
                Point p1 = (Point)this._points[i];
                Point p2 = (Point)this._points[i + 1];
                g.DrawLine(_pen, p1.X, p1.Y, p2.X, p2.Y);
            }

        }
        internal override void Update(Graphics g, int x, int y)
        {
            Update(x, y);
            Point p1 = (Point)_points[_points.Count - 2] ;
            Point p2 = (Point)_points[_points.Count - 1];
            g.DrawLine(_pen,p1,p2);
        }
       private void Update(int x, int y)
        {
            Point p = new Point(x, y);
            _points.Add(p);
        }


    }


}
