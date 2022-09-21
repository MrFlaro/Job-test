using System;

namespace ShapeMath.Lib.Primitives
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }


        /// <summary>
        /// Создать новый круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentOutOfRangeException">При отрицательном значении входного радиуса</exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Значение радиуса не может быть отрицательным");

            Radius = radius;
        }


        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        /// <returns>Значение площади круга</returns>
        protected override sealed double CalculateAreaSquare()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
