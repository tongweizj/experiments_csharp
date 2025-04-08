using System;

abstract class Parent : IDrawable
{
    protected Color Color { get; }
    protected bool Filled { get; }
    protected Rectangle Rectangle { get; }
    public Parent(Color color, bool filled, Rectangle rect)
        => (Color, Filled, Rectangle) = (color, filled, rect);
    public abstract void Draw(Graphics g);
}