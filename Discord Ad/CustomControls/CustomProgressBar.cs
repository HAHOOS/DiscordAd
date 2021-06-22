using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Discord_Ad.CustomProgressBar
{
    class CustomProgressBar : ProgressBar
    {
        //Fields
        private Color backgroundColor = Color.Gray;
        private Color progressColor = Color.Green;
        Bitmap bitmap;
        Graphics g;
        double pbUnit;
        //Properties
        [Category("HS Creations")]
        public Color BackgroundColor
        {
            get
            {
                return backgroundColor;
            }

            set
            {
                backgroundColor = value;
                this.Invalidate();
            }
        }

        [Category("HS Creations")]
        public Color ProgressColor
        {
            get
            {
                return progressColor;
            }

            set
            {
                progressColor = value;
                this.Invalidate();
            }
        }

        public CustomProgressBar()
        {
            this.MinimumSize = new Size(200, 10);
        }

        //Methods
        
        
        
        protected override void OnPaint(PaintEventArgs pevent)
        {
            pbUnit = this.Maximum;
            bitmap = new Bitmap(this.Width, this.Height);

            g = Graphics.FromImage(bitmap);

            g.Clear(backgroundColor);

            g.FillRectangle(Brushes.Gray, new Rectangle(0, 0, (int)(this.Maximum * pbUnit), this.Height));


        }
    }
}
