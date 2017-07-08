using System;

namespace Inheritence
{
  class Shape
  {
    protected int width;
    protected int height;

    public void setWidth(int w)
    {
      width = w;
    }
    public void setHeight(int h)
    {
      height = h;
    }
  }

  //Derived class

  class Rectangle: Shape
  {
    public int getArea()
    {
      return (width * height);
    }
  }

  //Main method and object class

  class RectangleTester
  {
    static void Main(string[] args)
    {
      Rectangle Rect = new Rectangle();
      Rect.setWidth(10);
      Rect.setHeight(12);

      Console.WriteLine("Total area: {0}", Rect.getArea());
      Console.ReadKey();
    }
  }
}
