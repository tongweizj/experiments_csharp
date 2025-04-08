using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace DrawFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interfaces are types.
            List<IDrawable> face = new List<IDrawable>();
            face.Add(new DrawableEllipse(Color.Yellow, true, new Rectangle(75, 160, 40, 70)));      //left ear
            face.Add(new DrawableEllipse(Color.BlueViolet, false, new Rectangle(75, 160, 40, 70))); //left ear
            face.Add(new DrawableEllipse(Color.Yellow, true, new Rectangle(285, 160, 40, 70)));     //right ear
            face.Add(new DrawableEllipse(Color.BlueViolet, false, new Rectangle(285, 160, 40, 70)));//right ear
            face.Add(new DrawableRectangle(Color.Salmon, true, new Rectangle(100, 100, 200, 300))); //face
            face.Add(new DrawableRectangle(Color.White, true, new Rectangle(140, 165, 45, 60)));    //right eye
            face.Add(new DrawableRectangle(Color.White, true, new Rectangle(220, 165, 45, 60)));    //left eye
            face.Add(new DrawableRectangle(Color.Black, true, new Rectangle(150, 183, 25, 40)));    //right pupil
            face.Add(new DrawableRectangle(Color.Black, true, new Rectangle(230, 183, 25, 40)));    //left pupil
            face.Add(new DrawableRectangle(Color.Brown, true, new Rectangle(90, 10, 220, 120)));    //hat top
            face.Add(new DrawableRectangle(Color.Brown, true, new Rectangle(10, 100, 380, 20)));    //hat rim

            //face.Add(new DrawableBezier(Color.Black, new Point(195, 240), new Point(215, 240), new Point(135, 280), new Point(275, 280))); //nose

            face.Add(new DrawableEllipse(Color.Red, false, new Rectangle(150, 300, 100, 35)));      //lips
            face.Add(new DrawableEllipse(Color.Wheat, true, new Rectangle(160, 305, 80, 25)));      //mouth
            face.Add(new DrawableLine(Color.Red, new Point(105, 30), new Point(105, 100)));         //lines
            face.Add(new DrawableLine(Color.Orange, new Point(127, 30), new Point(127, 100)));      //lines
            face.Add(new DrawableLine(Color.Yellow, new Point(155, 30), new Point(155, 100)));      //lines
            face.Add(new DrawableLine(Color.Green, new Point(200, 30), new Point(200, 100)));       //lines
            face.Add(new DrawableLine(Color.Blue, new Point(245, 30), new Point(245, 100)));        //lines
            face.Add(new DrawableLine(Color.Indigo, new Point(273, 30), new Point(273, 100)));      //lines
            face.Add(new DrawableLine(Color.Violet, new Point(295, 30), new Point(295, 100)));      //lines
            //face.Add(new DrawableArc(Color.Gray, true, new Rectangle(170, 300, 60, 140), 0, 180));  //goatee

            int width = 400, length = 450;

            using (Bitmap bmp = new Bitmap(width, length))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    foreach (var item in face)
                    {
                        item.Draw(g);//this is polymorphic behavior
                        if (item is IWriteable)
                        {
                            ((IWriteable)item).Write(System.Console.Out);
                        }
                    }
                    bmp.Save("face.png", ImageFormat.Png);
                }
            }

        }
    }

    // interface
    interface IDrawable { void Draw(Graphics g); }
    interface IWriteable { void Write(TextWriter writer); }

    abstract class Parent : IDrawable
    {
        protected Color Color { get; }
        protected bool Filled { get; }
        protected Rectangle Rectangle { get; }

        // constract
        public Parent(Color color, bool filled, Rectangle rect)
            => (Color, Filled, Rectangle) = (color, filled, rect);

        // from IDrawable
        public abstract void Draw(Graphics g);
    }

    /* 
     * base
     * https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/base
     * 
     */

    class DrawableRectangle : Parent, IWriteable
    {
        public DrawableRectangle(Color color, bool filled, Rectangle rectangle)
            : base(color, filled, rectangle)
        { }


        public override void Draw(Graphics g)
        {
            if (Filled)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillRectangle(brush, Rectangle);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawRectangle(pen, Rectangle);
            }
        }


        public void Write(TextWriter writer)
        {
            writer.Write($"\nRectangle {Color.ToKnownColor()} {(Filled ? "" : "not ")}filled {Rectangle}");
        }
    }


    class DrawableEllipse : Parent, IWriteable
    {
        public DrawableEllipse(Color color, bool filled, Rectangle rectangle)
            : base(color, filled, rectangle)
        { }


        public override void Draw(Graphics g)
        {
            if (Filled)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillEllipse(brush, Rectangle);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawEllipse(pen, Rectangle);
            }
        }


        public void Write(TextWriter writer)
        {
            writer.Write($"\nEllipse {Color.ToKnownColor()} {(Filled ? "" : "not ")}filled {Rectangle}");
        }
    }

    class DrawableLine : IDrawable, IWriteable
    {
        public Color Color { get; }
        public Point Start { get; }
        public Point End { get; }

        public DrawableLine(Color color, Point start, Point end)
            => (Color, Start, End) = (color, start, end);

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color);
            g.DrawLine(pen, Start, End);
        }

        public void Write(TextWriter writer)
        {
            writer.Write($"\nLine {Color.ToKnownColor()} {Start} {End}");

        }
    }
}
