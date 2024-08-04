using DressageScoreSheet;

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
    Console.WriteLine("Enter the number of test : ");

    userInput = Console.ReadLine();

    if (userInput == "1")
    {
        //internal class of Intro A to do the calculation there for that specific test, do this for the rest. 
        IntroA introA = new IntroA();
        introA.CalculateIAScore();

    }
    else
    {
        Console.WriteLine("App is still under development. Come back later.");
        
    }
    










