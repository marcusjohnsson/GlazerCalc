using System;

class GlazerCalc
{
   static void Main()
    {
        double width, height, woodLength, glassArea;
        string widthString, heightString, res;

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
