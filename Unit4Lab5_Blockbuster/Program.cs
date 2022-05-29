using Unit4Lab5_Blockbuster;

DVD DVD1 = new DVD("Bringing Down The House", 92, Category.Comedy, new List<string>() {"Scene 1", "Scene 2", "Scene 3", "Scene 4"  });

Console.WriteLine("Welcome to the Bledsoe Blockbuster Application");
PauseAndClearScreen();

bool runningProgram = true;
while (runningProgram)
{
    DVD1.PrintInfo();
    DVD1.Play();
    PauseAndClearScreen();
    runningProgram = false;
}
Console.WriteLine("Thank you for using the Bledsoe Blockbuster Application for all of your movie needs!");
Console.WriteLine("Goodbye...");

static void PauseAndClearScreen()
{
    Console.WriteLine();
    Console.WriteLine("Press Enter to Continue.");
    Console.ReadLine();
    Console.Clear();
}