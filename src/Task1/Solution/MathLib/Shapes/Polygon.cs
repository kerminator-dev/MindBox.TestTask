using System.Drawing;

namespace MathLib.Shapes
{
    /// <summary>
    /// Многоугольник
    /// </summary>
    public class Polygon : Shape
    {
        private readonly Point[] _points;

        /// <summary>
        /// Точки на Декартовой Системе Координат
        /// </summary>
        public Point[] Points => _points;

        /// <summary>
        /// Многоуольник
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="points">Точки, минимум 3</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Polygon(params Point[] points) 
            : this("Polygon", points)
        {
            
        }

        /// <summary>
        /// Многоуольник
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="points">Точки, минимум 3</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public Polygon(string name, params Point[] points) : base(name)
        {
            if (points == null)
                throw new ArgumentNullException(nameof(points));

            if (points.Length < 3)
                throw new ArgumentException("Минимальное количество точек должно быть 3!", nameof(points));

            _points = points;
        }

        /// <summary>
        /// Получить площадь
        /// </summary>
        /// <returns>Площадь многоугольника</returns>
        public override double GetArea()
        {
            double sum1 = 0;
            double sum2 = 0;

            for (int i = 0; i < Points.Length - 1; i++)
            {
                sum1 += Points[i].X * Points[i + 1].Y;
                sum2 += Points[i].Y * Points[i + 1].X;
            }

            return Math.Abs((sum1 - sum2) / 2d);
        }

    }
}
