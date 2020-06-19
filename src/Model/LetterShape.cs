using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw.src.Model
{
    [Serializable]
    class LetterShape : Shape
    {
        #region constructor

        public LetterShape(RectangleF Let) : base(Let)
        {
        }

        public LetterShape(LetterShape letter) : base(letter) 
        { 
        }
        #endregion

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            { 
                return true; 
            }
            else 
            {
                return false;
            }
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            base.RotateShape(grfx);

            grfx.FillRectangle(new SolidBrush(Color.FromArgb(Opacity,FillColor)),Rectangle.X,Rectangle.Y,Rectangle.Width,Rectangle.Height);
            grfx.DrawRectangle(new Pen(BorderColor,BorderWidth),Rectangle.X,Rectangle.Y,Rectangle.Width,Rectangle.Height);
            grfx.DrawLine(new Pen(BorderColor, BorderWidth), Rectangle.X, Rectangle.Y, Rectangle.X + (Rectangle.Width / 2),Rectangle.Y + (Rectangle.Height/2));
            grfx.DrawLine(new Pen(BorderColor, BorderWidth), Rectangle.X + Rectangle.Width, Rectangle.Y, Rectangle.X + (Rectangle.Width / 2),Rectangle.Y + (Rectangle.Height/2));

            grfx.ResetTransform();
        }

    }
}
