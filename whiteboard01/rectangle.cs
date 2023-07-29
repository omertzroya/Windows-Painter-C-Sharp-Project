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
    internal class rectangle : Figure
    {

        private  int _x;
        private  int _y;
        private int _Width;
        private int _Height;


        internal rectangle(bool IsFilled,int x, int y, Color c, float width) : base(c, width)
        {

            _x = x;
            _y = y;
            _IsFilled = IsFilled;

        }
        internal override void Draw(Graphics g)
        {
            if (_IsFilled == false)
            {
                g.DrawRectangle(_pen, _x, _y, _Width, _Height);
            }
            else {
             
                g.FillRectangle(_brush, _x, _y, _Width, _Height);
            }
        }
        internal override void Update(Graphics g, int x, int y)
        {
            _Width = x - _x;
            _Height = y - _y;

            if (_Width < 0)
            {
                _x = x;
                _Width = -1*_Width;

            }
            if (_Height < 0)
            {
                _y = y;
                _Height = -1 * _Height;

            }
            Draw(g);

        }

        internal override bool IsPointIn(int x, int y) {

            if (x < _x) {
                return false;
            }
            if (y < _y) {
                return false;
            }
            if (x > _x + _Width)
            {
                return false;
            }
            if (y > _y + _Height)
            {
                return false;
            }

            return true; 
        }

    }
}
