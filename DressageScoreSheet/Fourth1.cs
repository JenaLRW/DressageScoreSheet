using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressageScoreSheet
{
    internal class Fourth1
    {

        public void CalculateScore()
        {


            Console.WriteLine("2023 USDF Second Level - Test 1");

            double[] totalPoints = new double[29];
            double[] coef = { 1, 2, 2, 2, 1, 1, 1, 1, 1, 1, 2, 2, 1, 1, 1, 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 2, 2, 1, 1 };

            for (int i = 0; i < 29; i++)
            {
                Console.WriteLine($"Movement {i + 1}: ");

                string input = Console.ReadLine();

                if (double.TryParse(input, out double pointsValue))
                {

                    totalPoints[i] = pointsValue;

                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    i--;
                }



            }






            Console.WriteLine($"Errors: ");

            string inputErrors = Console.ReadLine();



            if (int.TryParse(inputErrors, out int errorsValue))
            {

                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"Invalid input.");

            }





            double sum = 0;

            for (int i = 0; i < 29; i++)
            {
                sum += totalPoints[i] * coef[i];


            }

            Console.WriteLine($"\t\t\tTotal points: {sum}\n");

            int maxPoints = 380;

            double percentage = ((sum - errorsValue) / maxPoints) * 100;


            Console.WriteLine($"\t\t\tPercentage: {percentage:F3}");
        }
    }
}
