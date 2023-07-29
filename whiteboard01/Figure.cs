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
    internal abstract class Figure : Shape
    {
        protected bool _IsFilled;

        public Figure(Color c, float width) : base(c, width)  { }
    
    }
}
