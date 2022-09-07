namespace MathLib.Shapes
{
    /// <summary>
    /// Фигура
    /// </summary>
    public abstract class Shape
    {
        protected string _name;

        /// <summary>
        /// Название фигуры
        /// </summary>
        public virtual string Name => _name;

        /// <summary>
        /// Фигура
        /// </summary>
        /// <param name="name">Название фигуры</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Shape(string name)
        {
            // Обработка исключения
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            _name = name;
        }

        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea(); 
    }
}
