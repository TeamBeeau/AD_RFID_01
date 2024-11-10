using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_RFID
{
    [Serializable()]
    public class RJButton : Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;

        //Properties
        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("RJ Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }
        bool _IsRect=false;
        Image imgChoose = Properties.Resources.btnChoose;
        Image imgSelect = Properties.Resources.btnSelect;
        Image imgUnChoose = Properties.Resources.btnUnChoose;
        [Category("Bool Button Rect")]
        public Boolean IsRect
        {
            get { return this._IsRect; }
            set { this._IsRect = value;
                if(_IsRect)
                {
                    imgChoose = Properties.Resources.btnChoose2;
                    imgUnChoose = Properties.Resources.btnUnChoose2;
                    imgSelect = Properties.Resources.btnSelect2;
                }
                this.Invalidate();

            }
        }
       
        public bool IsCLick {
            get { return this.isCLick; }
            set
            {
                this.isCLick = value;
                if (value)
                {
                    this.BackgroundImage = imgChoose;
                }
                else
                    this.BackgroundImage = imgUnChoose;
                if(value==true&&!this.IsUnGroup&&this.Parent!=null)
                foreach (Control c in this.Parent.Controls)
                {

                    if (c is RJButton && c != this)
                    {
                        RJButton btn = c as RJButton;
                        btn.IsCLick = false;
                        this.borderColor = Color.Silver;
                        c.BackgroundImage = imgUnChoose;
                    }
                }
                this.Invalidate();

            }
        }
        private bool isNotChange;
        [Category("Bool Button Rect")]
        public bool IsNotChange { get => isNotChange; set
            {
                isNotChange = value; this.Invalidate();
            }
        }

        public bool IsUnGroup { get => isUnGroup; set { isUnGroup = value; this.Invalidate(); } }

        //Constructor
        public RJButton()
        {
           
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackgroundColor = Color.Transparent;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
            this.MouseMove += RJButton_MouseMove;
            this.MouseLeave += RJButton_MouseLeave;
            this.Click += RJButton_Click;
           
            if (_IsRect)
            {
                imgChoose = Properties.Resources.btnChoose2;
                imgUnChoose = Properties.Resources.btnUnChoose2;
                imgSelect = Properties.Resources.btnSelect2;
            }else
            {
                imgChoose = Properties.Resources.btnChoose;
                imgUnChoose = Properties.Resources.btnUnChoose;
                imgSelect = Properties.Resources.btnSelect;

            }
            if(IsCLick)
            this.BackgroundImage = imgChoose;
            else
                this.BackgroundImage = imgUnChoose;
        }
        private bool isCLick = false;
        private bool isUnGroup;

        private Image imgOld;
        private void RJButton_Click(object sender, EventArgs e)
        {if (isNotChange) return;
           
            if (IsUnGroup)
            {
                IsCLick = !IsCLick;
                return;
            }
            else
                
            this.IsCLick = true;
            
            foreach (Control c in this.Parent.Controls)
            {

                if(c is RJButton&&c!=this)
                {
                    RJButton btn = c as RJButton;
                    btn.IsCLick = false;
                    this.borderColor = Color.Silver;
                    c.BackgroundImage= imgUnChoose;
                }
            }

        }

        private void RJButton_MouseLeave(object sender, EventArgs e)
        {
            
                if (!IsCLick)
                    this.BackgroundImage = imgUnChoose;
                else
                    this.BackgroundImage = imgChoose;
                this.borderColor = Color.Silver;
            
        }

        private void RJButton_MouseMove(object sender, MouseEventArgs e)
        {
         
            if (!IsCLick)
                this.BackgroundImage = imgSelect;
            this.borderColor = Color.Silver;
        }

        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);


            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }
    }
}   

