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
    internal class Line : Shape
    {
        // DataMember 
        private Point _p1;
        private Point _p2;

        
        // counstractor 
        internal Line(int x , int y,Color c,float width) : base(c,width)
        {
            _p1.X = x;
            _p1.Y = y;
           
        }

        internal override void Draw(Graphics g)
        { 
            g.DrawLine(_pen, _p1.X, _p1.Y, _p2.X, _p2.Y);
        }

        internal override void  Update(Graphics g, int x, int y)
        {

            _p2.X = x;
            _p2.Y = y;
            Draw(g);

        }

     

    }
}
