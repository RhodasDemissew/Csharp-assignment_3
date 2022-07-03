using System;




Console.WriteLine("Select a Shape:");
Console.WriteLine("1.Circle");
Console.WriteLine("2.Triangle");
Console.WriteLine("3.Square");
Console.WriteLine("4.Rectangle");
int x = Convert.ToInt32(Console.ReadLine());
if (x==1)
{
    
        
            Circle circle = new Circle();
            Console.WriteLine("Enter the radius:");
           
            circle._rad = Console.ReadLine();

            Console.WriteLine("Calculate:");
            Console.WriteLine("1.Area");
            Console.WriteLine("2.Perimeter");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("The Area of the Circle is:" + circle.area());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("The Circumference of the Circle is:" + circle.perimeter());
                        break;
                    }
            }
            
        }
    if (x==2)
        {
            Triangle triangle = new Triangle();
            Console.WriteLine("Assuming Right angle triangle!");
            Console.WriteLine("Enter Side A,B,C respectively:");
           
            triangle._A = Console.ReadLine();
            triangle._B = Console.ReadLine();
            triangle._C = Console.ReadLine();

            Console.WriteLine("Calculate:");
            Console.WriteLine("1.Area");
            Console.WriteLine("2.Perimeter");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("The Area of the Triangle is:" + triangle.area());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("The Perimeter of the Triangle is:" + triangle.perimeter());
                        break;
                    }
            }
            
        }
    if(x==3)
        {
            Square square = new Square();
            Console.WriteLine("Enter the length:");
          
            square._w = Console.ReadLine();

            Console.WriteLine("Calculate:");
            Console.WriteLine("1.Area");
            Console.WriteLine("2.Perimeter");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("The Area of the Square is:" + square.area());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("The Perimeter of the Square is:" + square.perimeter());
                        break;
                    }
            }
            
        }
    if(x==4)    
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Enter length and width respectively:");
           
            rectangle._l = Console.ReadLine();
            rectangle._w = Console.ReadLine();

            Console.WriteLine("Calculate:");
            Console.WriteLine("1.Area");
            Console.WriteLine("2.Perimeter");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("The Area of the Rectangle is:" + rectangle.area());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("The Perimeter of the Rectangle is:" + rectangle.perimeter());
                        break;
                    }
            }
            
        }






abstract class Shape
{
    abstract public Double area();
    abstract public Double perimeter();

}
class Circle : Shape
{ 
    private string rad = " ";
    public string _rad
    {
        get { return rad; }
        set { rad = value; }
    }
   
    public override Double area()
    {
        return 3.14 * (Convert.ToDouble(rad) * Convert.ToDouble(rad));
    }

    public override Double perimeter()
    {
        return 2 * (3.14 * Convert.ToDouble(rad));
    }
}
class Triangle : Shape
{
    private string A = " ";
    public string _A
    {
        get { return A; }
        set { A = value; }
    }
    private string B = " ";
    public string _B
    {
        get { return B; }
        set { B = value; }
    }
    private string C = " ";
    public string _C
    {
        get { return C; }
        set { C = value; }
    }
   
    public override double area()
    {
        return Convert.ToDouble(A) * Convert.ToDouble(B) / 2;
    }

    public override double perimeter()
    {
        return Convert.ToDouble(A) + Convert.ToDouble(B) + Convert.ToDouble(C);
    }
}
class Square : Shape
{
    private string w = " ";
    public string _w
    {
        get { return w; }
        set { w = value; }
    }
   
    public override double area()
    {
        return Convert.ToDouble(w) * Convert.ToDouble(w);
    }

    public override double perimeter()
    {
        return 4 * Convert.ToDouble(w);
    }
}
class Rectangle : Shape
{
    private string l = " ";
    public string _l
    {
        get { return l; }
        set { l = value; }
    }
    private string w = " ";
    public string _w
    {
        get { return w; }
        set { w = value; }
    }
   

   
    public override double area()
    {
        return Convert.ToDouble(l) * Convert.ToDouble(w);
    }

    public override double perimeter()
    {
        return 2 * Convert.ToDouble(l) + 2 * Convert.ToDouble(w);
    }
}
