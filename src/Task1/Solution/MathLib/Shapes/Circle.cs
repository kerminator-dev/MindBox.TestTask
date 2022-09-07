namespace MathLib.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {        
        private double _radius;

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius
        {
            get => _radius;
            set => _radius = value;
        }

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(double radius) : this("Circle", radius) { }

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="name">Название фигуры</param>
        /// <param name="radius">Радиус</param>
        public Circle(string name, double radius) : base(name)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException(nameof(radius));

            Radius = radius;
        }

        /// <summary>
        /// Получить площадь
        /// </summary>
        /// <returns>Площадь окружности</returns>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
