using System;

/* 
public class Rectangle
{  
   public double Height {get;set;}  
   public double Wight {get;set; }  
}  
public class AreaCalculator {  
   public double TotalArea(Rectangle[] arrRectangles)  
   {  
      double area;  
      foreach(var objRectangle in arrRectangles)  
      {  
         area += objRectangle.Height * objRectangle.Width;  
      }  
      return area;  
   }  
}  
public class AreaCalculator {  
   public double TotalArea(Rectangle[] arrRectangles)  
   {  
      double area;  
      foreach(var objRectangle in arrRectangles)  
      {  
         area += objRectangle.Height * objRectangle.Width;  
      }  
      return area;  
   }  
}  
public class Rectangle{  
   public double Height {get;set;}  
   public double Wight {get;set; }  
}  
public class Circle{  
   public double Radius {get;set;}  
}  
public class AreaCalculator  
{  
   public double TotalArea(object[] arrObjects)  
   {  
      double area = 0;  
      Rectangle objRectangle;  
      Circle objCircle;  
      foreach(var obj in arrObjects)  
      {  
         if(obj is Rectangle)  
         {  
            objRectangle = (Rectangle)obj;  
            area += obj.Height * obj.Width;  
         }  
         else  
         {  
            objCircle = (Circle)obj;  
            area += objCircle.Radius * objCircle.Radius * Math.PI;  
         }  
      }  
      return area;  
   }  
}   
 */
public abstract class Shape
{
    public abstract double Area();
}

public class Rectangle : Shape
{
    public double Height = 10;
    public double Width = 12;
    public override double Area()
    {
        return Height * Width;
    }
}
public class Circle : Shape
{
    public double Radius = 4;
    public override double Area()
    {
        return Radius * Radius * Math.PI;
    }
}

public class AreaCalculator
{
    public double TotalArea(Shape[] arrShapes)
    {
        double area = 0;
        foreach (var objShape in arrShapes)
        {
            area += objShape.Area();
        }
        return area;
    }
}

public class Ocd
{
    public static void Main()
    {
        Shape rect = new Rectangle();
        Shape circle = new Circle();
        Console.WriteLine("area of rectangle: " + rect.Area());
        Console.WriteLine("area of circle: " + circle.Area());
    }
}
