using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace whiteboard01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList Drawings = new ArrayList(); // ArrayList – מייצג אוסף דינמי של פריטים במקרה שלנו אוסף של קווים .
        Shape _selected;
        private void HandleSlideControls() { // טיפול בחריגות של הסלידים שיש חריגה מהמערך 

            if (Drawings.Count > 1)
              buttonDeleteSlide.Enabled = true;
            else 
               buttonDeleteSlide.Enabled = false;
         
            int currentSlide = int.Parse(textBoxSlideNumber.Text);
            bool last = currentSlide == Drawings.Count - 1;
            buttonShowNextSlide.Enabled = !last;
          
            bool first = currentSlide == 0;
            buttonShowPreviousSlide.Enabled = !first;

        }

       
        private void panel1_Paint(object sender, PaintEventArgs e) //צריך את זה לשמירה של הציור שלי 
        {
            int currentSilde = int.Parse(textBoxSlideNumber.Text);
            ArrayList shapes= (ArrayList)Drawings[currentSilde];
            
            foreach (Shape s in shapes) // לולאת foreach היא לולאה שמותאמת במיוחד לעבודה עם מערכים. בלולאה מסוג זה אין צורך להגדיר משתנה שימנה את מספר האיטרציות שעברנו.                                   //  במקום זה הלולאה עוברת באופן אוטומטי על כל איברי המערך.
            {
                // פולימורפיזם ריבוי פנים לדבר הזה החלטה בזמן ריצה למי אני קורא 
                s.Draw(e.Graphics); //   אם לא היה ירושה הייתי צריך לעשות איפ לכל מה שרצית לצייר ופה זה בוחר לפי הירושה איזה דרואו לבחור 
            }
        }


       
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Left)
            {

                if (radioButtonFreeHand.Checked == true) {

                    int currentSlide = int.Parse(textBoxSlideNumber.Text);
                    ArrayList shapes = (ArrayList)Drawings[currentSlide];
                    FreeHand fh = (FreeHand)shapes[shapes.Count - 1];

                    Graphics g = this.panel1.CreateGraphics();
                    fh.Update(g, e.X, e.Y);
        
                }
  
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList lines = new ArrayList();
            Drawings.Add(lines);
            _currentWidth = panelWidth1;
            HandleSlideControls();
        }

        private void buttonAddNewSlide_MouseClick(object sender, MouseEventArgs e)
        {
            ArrayList lines = new ArrayList();
            Drawings.Add(lines);
            int num = Drawings.Count - 1;
            textBoxSlideNumber.Text = num.ToString();
            HandleSlideControls();
            panel1.Invalidate(); // ציירי את עצמך מחדש
        }

        private void buttonShoePreviousSlide_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBoxSlideNumber.Text);
            num--;
            textBoxSlideNumber.Text = num.ToString();
            HandleSlideControls();
            panel1.Invalidate(); // ציירי את עצמך מחדש

        }

        private void buttonShowNextSlide_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBoxSlideNumber.Text);
            num++;
            textBoxSlideNumber.Text = num.ToString();
            HandleSlideControls();
            panel1.Invalidate(); // ציירי את עצמך מחדש
        }

       

        private void buttonShowLastSlide_Click(object sender, EventArgs e)
        {
            int num = Drawings.Count - 1;
            textBoxSlideNumber.Text = num.ToString();
            HandleSlideControls();
            panel1.Invalidate();

        }

        

        private void HandlePanelsWidths(Panel p ,int h,Graphics g) {
           
            Brush fg;
            if (p == _currentWidth)
            {
                p.BackColor = Color.Blue;
                fg = Brushes.White;
            }
            else {
                p.BackColor = Color.Empty;
                fg = Brushes.Black;

            }
            int x = 3;
            int y = (p.Height - h) / 2;
            int w = p.Width - x * 2;

           Rectangle r = new Rectangle(x, y, w, h);
           g.FillRectangle(fg, r);

        }


        private void panelWidth1_Paint(object sender, PaintEventArgs e)
        {
            HandlePanelsWidths((Panel)sender,1,e.Graphics);
        }
        
        private void panelWidth2_Paint(object sender, PaintEventArgs e)
        {
            HandlePanelsWidths((Panel)sender, 2, e.Graphics);
           
        }

        private void panelWidth3_Paint(object sender, PaintEventArgs e)
        {
            HandlePanelsWidths((Panel)sender, 3, e.Graphics);
           
        }

        private void panelWidth4_Paint(object sender, PaintEventArgs e)
        {
            HandlePanelsWidths((Panel)sender, 4, e.Graphics);
           
        }

        private void buttonShowFirstSlide_Click(object sender, EventArgs e)
        {
            textBoxSlideNumber.Text = "0";
            HandleSlideControls();
            panel1.Invalidate();
        }

        private void buttonDeleteSlide_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBoxSlideNumber.Text);
            Drawings.RemoveAt(num);
            if (num == Drawings.Count) {
                num--;
                textBoxSlideNumber.Text = num.ToString();
            }
            HandleSlideControls();
            panel1.Invalidate();
        }




        private Panel _currentWidth;

        private void InvalidatePanelWidth() {

            panelWidth1.Invalidate();
            panelWidth2.Invalidate();
            panelWidth3.Invalidate();
            panelWidth4.Invalidate();

        }
     
        private void panelWidth1_MouseDown(object sender, MouseEventArgs e)
        {

            _currentWidth =panelWidth1;
            InvalidatePanelWidth();
        }

        private void panelWidth2_MouseDown(object sender, MouseEventArgs e)
        {
            _currentWidth = panelWidth2;
            InvalidatePanelWidth();
        }

        private void panelWidth3_MouseDown(object sender, MouseEventArgs e)
        {
            _currentWidth = panelWidth3;
            InvalidatePanelWidth();

        }

        private void panelWidth4_MouseDown(object sender, MouseEventArgs e)
        {
            _currentWidth = panelWidth4;
            InvalidatePanelWidth();
        }

        private void buttonColorRed_Click(object sender, EventArgs e)
        {
            panelSelectedColor.BackColor = Color.Red;
        }

        private void buttonColorBlue_Click(object sender, EventArgs e)
        {
            panelSelectedColor.BackColor = Color.Blue;
        }

        private void buttonColorYellow_Click(object sender, EventArgs e)
        {
            panelSelectedColor.BackColor = Color.White;
        }

        private void buttonColorGreen_Click(object sender, EventArgs e)
        {
            panelSelectedColor.BackColor = Color.Green;

        }

        private void buttonColorWhite_Click(object sender, EventArgs e)
        {
            panelSelectedColor.BackColor = Color.Black;
        }

        

        private void panel1_MouseUp(object sender, MouseEventArgs e)

        {
            if (radioButtonSelector.Checked == true) {
                return; 
            }
            if (radioButtonEraser.Checked == true)
            {
                return;
            }


            if (radioButtonFreeHand.Checked == true) { return; }

                int currentSlide = int.Parse(textBoxSlideNumber.Text);
                ArrayList shapes = (ArrayList)Drawings[currentSlide];
                Shape s  = (Shape)shapes[shapes.Count - 1];

                Graphics g = this.panel1.CreateGraphics();
                s.Update(g,e.X,e.Y);
             
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButtonSelector.Checked == true || radioButtonEraser.Checked == true)
            {
                int currentSlide = int.Parse(textBoxSlideNumber.Text);
                ArrayList Shapes = (ArrayList)Drawings[currentSlide];

                foreach (Shape m in Shapes) {

                  bool b =  m.IsPointIn(e.X, e.Y);
                    if (b==true) {

                        if (radioButtonEraser.Checked == true) {

                            Shapes.Remove(m);
                            panel1.Invalidate();
                        }
                        if (radioButtonSelector.Checked == true)
                        {
                            _selected = m;
                            _selected._Color = panelSelectedColor.BackColor;

                        }
                       
                        return;
                    
                    }
               
                }
                _selected =null;
                return;
            }


            Shape s = null;
            Color c =  panelSelectedColor.BackColor;
            string sWidth = (string)_currentWidth.Tag;
            float width = float.Parse(sWidth);
         
            if (radioButtonFreeHand.Checked == true) {
               s = new FreeHand(e.X, e.Y,c, width);
            }

            if (radioButtonLine.Checked == true) {
                s = new Line(e.X, e.Y,c, width);
            }
            if (radioButtonNonFillRectangle.Checked == true)
            {
                s = new rectangle(false,e.X, e.Y, c, width);
            }
            if (radioButtonFillRectangle.Checked == true)
            {
                s = new rectangle(true, e.X, e.Y, c, width);
            }
            if (radioButtonNonFillElipce.Checked == true)
            {
                s = new Ellipse(false, e.X, e.Y, c, width);
            }
            if (radioButtonFillElipce.Checked == true)
            {
                s = new Ellipse(true, e.X, e.Y, c, width);
            }

            int currentSilde = int.Parse(textBoxSlideNumber.Text);
            ArrayList shapes = (ArrayList)Drawings[currentSilde];
            shapes.Add(s);

        }

        private void panelSelectedColor_BackColorChanged(object sender, EventArgs e)
        {

            Color c = panelSelectedColor.BackColor;
            if (radioButtonSelector.Checked == true) {
                if (_selected != null) {

                    _selected._Color = c;
                    panel1.Invalidate();

                }

            }
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string path = saveFileDialog1.FileName;
           using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            { 
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, Drawings);
            }
        }
        
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string path = openFileDialog1.FileName;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                SoapFormatter sf = new SoapFormatter();
                object o = sf.Deserialize(fs);
                Drawings = (ArrayList)o;
                panel1.Invalidate();
            }
        }
    }
}
