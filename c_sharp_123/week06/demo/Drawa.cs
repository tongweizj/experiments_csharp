using System;


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

