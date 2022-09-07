using MathLib.Shapes;
using System.Drawing;


var shapes = new List<Shape>();

shapes.Add
(
    new Polygon
    (
        new Point(0, 0),
        new Point(1, 0),
        new Point(3, 1),
        new Point(0, 1),
        new Point(-1, 0)
    )
);

shapes.Add
(
    new Triangle
    (
       1,
       1,
       1
    )
);

shapes.Add
(
    new Circle
    (
       3
    )
);

// Вывод
foreach (var shape in shapes)
    Console.WriteLine("{0}, area: {1}", shape.Name, shape.GetArea());

Console.Read();