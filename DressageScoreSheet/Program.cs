Console.WriteLine("2023 USDF Introductory Level - Test A");

double[] totalPoints = new double[15];
double[] coef = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1 };

for (int i = 0; i < 15; i++)
{
    totalPoints[i] = i;

    Console.WriteLine($"Movement {i + 1}: ");

    string input = Console.ReadLine();

    if (double.TryParse(input, out double pointsValue))
    {

        totalPoints[i] = pointsValue;

    }
    else
    {
        Console.WriteLine("Invalid input");
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
    Console.WriteLine($"Invalid input");
}





double sum = 0;

for (int i = 0; i < 15; i++)
{
    sum += totalPoints[i] * coef[i];


}

Console.WriteLine($"\t\t\tTotal points: {sum}\n");

int maxPoints = 160;

double percentage = ((sum - errorsValue) / maxPoints) * 100;


Console.WriteLine($"\t\t\tPercentage: {percentage:F3}");






