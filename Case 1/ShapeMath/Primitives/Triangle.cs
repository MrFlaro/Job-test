using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShapeMath.Lib.Primitives
{
    public class Triangle : Shape
    {

        public double ASide { get; private set; }
        public double BSide { get; private set; }
        public double CSide { get; private set; }

        public bool IsRightAngled { get; private set; }


        /// <summary>
        /// Создать новый треугольник
        /// </summary>
        /// <param name="sideA">Первая сторона</param>
        /// <param name="sideB">Вторая сторона</param>
        /// <param name="sideC">Третья сторона</param>
        /// <exception cref="ArgumentOutOfRangeException">Если значение одной из сторо равно или меньше нулю</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицальной или равняться нулю");

            ASide = sideA;
            BSide = sideB;
            CSide = sideC;

            IsRightAngled = CheckForRightAngled();
        }

        /// <summary>
        /// Проверка треугольника на наличие прямого угла
        /// </summary>
        /// <returns>true = прямоугольный треугольник</returns>
        protected bool CheckForRightAngled()
        {
            var maxSide = new[] { ASide, BSide, CSide }.Max();
            var maxSideSqr = maxSide * maxSide;
            return maxSideSqr + maxSideSqr == ASide * ASide + BSide * BSide + CSide * CSide; // hypotenuse^2 + hypotenuse^2 == cathetus^2 + cathetus^2 + hypotenuse^2


        }
        /// <summary>
        /// Вычмслить площадь треугольника
        /// </summary>
        /// <returns>Значение площади треугольника</returns>
        protected override double CalculateAreaSquare()
        {
            var halfPerimeter = (ASide + BSide + CSide) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - ASide) * (halfPerimeter - BSide) * (halfPerimeter - CSide)); // Herom's formula
        }
    }
}
