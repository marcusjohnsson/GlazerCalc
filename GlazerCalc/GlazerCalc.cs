using System;

class GlazerCalc
{
   static void Main()
    {
        double width, height, woodLength, glassArea;
        string greeting, widthString, heightString, res;

        greeting =
@"The app prompts for two variables. width and height.
Then process and print out the amount of wood and glass
materials required to make a double paned window that
will fit the dimensions provided.
::::::::::::::::::::::::::::::::::::::::::::::::::::::";
        Console.WriteLine(greeting);
        Console.WriteLine("Please state the width:");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        Console.WriteLine("Please state the height:");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height); // Area for two glass panes

        res = "The lenght of the wood is " + woodLength + " feet.";
        Console.WriteLine(res);

        res = "The area of the glass is " + glassArea + " sqm.";
        Console.WriteLine(res);
    }
}

// ÖVINING : Frågeställning

// 1)  Var initieras variabeln heightString?
//     Svar: heightString = Console.ReadLine();
// 2)  Var sker det en konkatenering i programmet?
//     Svar: Där res initieras.
// 3)  Vilka operatorer kan vi känna igen i programmet?
//     Svar: *, +, 
