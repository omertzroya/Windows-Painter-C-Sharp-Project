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
    internal abstract class Shape // אבסטרקטי אומר אין ישות מצויותת מסוד דיייפ או שאני מצייר לין או פרי הנד 
    {



        // Base class DataMember 
        private Color _color;
        private float _thickness;
     

    // get & set 
    internal Color _Color {

            get {
                return _Color;
            }

            set {
                _color = value;
            }
        
        }

        protected Pen _pen
        {
            get
            {
                return new Pen(_color, _thickness);
            }
        }
        protected Brush _brush
        {
            get
            {
                return new SolidBrush(_color);
            }
        }

        // Base Class Counstactor 
        internal Shape( Color c,float width) {  _color = c; _thickness = width; }

        //Metods 
        internal abstract void Draw(Graphics g);

        internal abstract void Update(Graphics g, int x, int y);

        internal virtual bool IsPointIn(int x, int y) { // פונקציה וירטואלית אם אין אותה לכל הבנים אז האב מופעל אם יש אותה לבן אז הבן מופעל 
            return false;
        }
     
    }
}
