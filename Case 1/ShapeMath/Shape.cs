using System;
using System.Threading;

namespace ShapeMath.Lib
{
    public abstract class Shape
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double AreaSquare
        {
            get => CalculateAreaSquare();
        }

        /// <summary>
        /// Вычислить площадь фигуры
        /// </summary>
        /// <returns></returns>
        protected abstract double CalculateAreaSquare();
    }
}
