namespace MathLib.Shapes
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Shape
    {
        protected readonly double _sideA;
        protected readonly double _sideB;
        protected readonly double _sideC;

        /// <summary>
        /// Длина стороны А
        /// </summary>
        public double SideA => _sideA;

        /// <summary>
        /// Длина стороны B
        /// </summary>
        public double SideB => _sideB;

        /// <summary>
        /// Длина стороны C
        /// </summary>
        public double SideC => _sideC;

        /// <summary>
        /// Полупериметр
        /// </summary>
        public double Semiperimeter => (SideA + SideB + SideC) / 2;


        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="name">Название фигуры</param>
        /// <param name="sideA">Длина стороны А</param>
        /// <param name="sideB">Длина стороны B</param>
        /// <param name="sideC">Длина стороны C</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Triangle(double sideA, double sideB, double sideC, string name = "Triangle") 
            : base(name)
        {
            // Обработка исключений

            // Отрицательные параметры
            if (sideA < 0)
                throw new ArgumentOutOfRangeException(nameof(sideA), "The side length of triangle should be more then 0!");

            if (sideB < 0)
                throw new ArgumentOutOfRangeException(nameof(sideB), "The side length of triangle should be more then 0!");

            if (sideC < 0)
                throw new ArgumentOutOfRangeException(nameof(sideC), "The side length of triangle should be more then 0!");

            // Одна сторона треугольника больше суммы двух других сторон
            if (sideA > sideB + sideC)
                throw new ArgumentOutOfRangeException(nameof(SideA), "One side of a triangle is greater than the sum of the other two sides!");

            if (sideB > sideA + sideC)
                throw new ArgumentOutOfRangeException(nameof(sideB), "One side of a triangle is greater than the sum of the other two sides!");

            if (sideC > sideA + sideB)
                throw new ArgumentOutOfRangeException(nameof(sideC), "One side of a triangle is greater than the sum of the other two sides!");

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }


        /// <summary>
        /// Получить площадь
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public override double GetArea()
        {
            // Реализация нахождения площади через формулу Герона
            return Math.Sqrt(this.Semiperimeter * (this.Semiperimeter - SideA) * (this.Semiperimeter - SideB) * (this.Semiperimeter - SideC));
        }

        /// <summary>
        /// Является ли прямоугольным треугольником
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular()
        {
            if (SideA * SideA + SideB * SideB == SideC * SideC)
                return true;

            if (SideA * SideA + SideC * SideC == SideB * SideB)
                return true;

            if (SideC * SideC + SideB * SideB == SideA * SideA)
                return true;

            return false;
        }
    }
}
