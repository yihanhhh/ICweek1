// See https://aka.ms/new-console-template for more information
using Week1ObjectOriented.Classes;

var square = new Square(10);

try
{


    square.SetArea(2);


    Console.WriteLine("The area is " + square.GetArea());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}




var circle = new Circle(2);

ShapeColourHelper.AddColour(circle);





ShapeColourHelper.AddColour(square);

Console.WriteLine(square.Colour);

ShapeColourHelper.ChangeColour(square);

Console.WriteLine(square.Colour);

var triangle = new Triangle();

ShapeColourHelper.AddColour(triangle);
Console.WriteLine(triangle.Colour);



Console.ReadLine();




