using DressageScoreSheet;
using System.Net.Http.Json;

//static void Main()
string userInput = string.Empty;
    

Console.WriteLine("1. 2023 USEF Introductory Level Test A");
//Console.WriteLine("2. 2023 USEF Introductory Level Test B");
//Console.WriteLine("3. 2023 USEF Introductory Level Test C");
Console.WriteLine();
Console.WriteLine("4. 2023 USEF Training Level Test 1");
//Console.WriteLine("5. 2023 USEF Training Level Test 2");
//Console.WriteLine("6. 2023 USEF Training Level Test 3");
Console.WriteLine();
Console.WriteLine("7. 2023 USEF First Level Test 1");
//Console.WriteLine("8. 2023 USEF First Level Test 2");
//Console.WriteLine("9. 2023 USEF First Level Test 3");
Console.WriteLine();
Console.WriteLine("10. 2023 USEF Second Level Test 1");
//Console.WriteLine("11. 2023 USEF Second Level Test 2");
//Console.WriteLine("12. 2023 USEF Second Level Test 3");
Console.WriteLine();
Console.WriteLine("13. 2023 USEF Third Level Test 1");
//Console.WriteLine("14. 2023 USEF Third Level Test 2");
//Console.WriteLine("15. 2023 USEF Third Level Test 3");
Console.WriteLine();
Console.WriteLine("16. 2023 USEF Fourth Level Test 1");
//Console.WriteLine("17. 2023 USEF Fourth Level Test 2");
//Console.WriteLine("18. 2023 USEF Fourth Level Test 3");
Console.WriteLine();
Console.WriteLine("Enter the number of test to score: ");

userInput = Console.ReadLine();

if (userInput == "1")
{
        
    IntroA introA = new IntroA();
    introA.CalculateScore();

}
if (userInput == "4")
{
    
    Training1 training1 = new Training1();
    training1.CalculateScore();

}
if (userInput == "7")
{

    First1 first1 = new First1();
    first1.CalculateScore();

}
if (userInput == "10")
{

    Second1 second1 = new Second1();
    second1.CalculateScore();

}
if (userInput == "13")
{

    Third1 third1 = new Third1();
    third1.CalculateScore();

}
if (userInput == "16")
{

    Fourth1 fourth1 = new Fourth1();
    fourth1.CalculateScore();

}
else
{
    Console.WriteLine("App is still under development. Come back later.");
        
}



static async Task Main(string[] args)
{
    using var client = new HttpClient();
    var input = new ScoreInputModel
    {
        TotalPoints = new double[] { },
        Coef = new double[] { },
        Errors = new int { }
    };

    var response = await client.PostAsJsonAsync("https://localhost:7277/api/DressageScoring/IntroA", input);
    var result = await response.Content.ReadFromJsonAsync<ScoreInputModel>();

    Console.WriteLine($"Percentage: {result.Percentage:F3}");
}





