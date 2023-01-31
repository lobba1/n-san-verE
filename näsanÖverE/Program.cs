using System;
using System.Collections.Generic;
ChooseCar();

void ChooseCar()
{
    // creates a string called "car", with 3 elements
    List<string> car = new List<string>();
    car.Add("Black");
    car.Add("White");
    car.Add("Grey");
    // foreach is a loop that runs and writes the elements to the console
    foreach (string cars in car)
    {
        Console.WriteLine(cars);
    }

    // welcomes player and asks them to choose car
    string blackCar = "One";
    Console.WriteLine("Welcome which of your 3 cars would you like to use today, 1, 2 or 3");
    // varar spelares svar
    string carName = "";
    int cNum = 0;
    // in loop until player types "Quit"
    while (carName != "Quit")
    {
        //läser användares svar
        carName = Console.ReadLine();
        bool whip = int.TryParse(carName, out cNum);
        // turns into int and stores in "cNum"

        // checks what the player writes and gives a response 
        if (cNum == 1)
        {
            Console.WriteLine("You are in the black benz, If you wish to change type Two or Three");
        }
        else if (cNum == 2)
        {
            Console.WriteLine("You are in the white Benz, if you wish to change type One or Three");
        }
        else if (cNum == 3)
        {
            Console.WriteLine("You are in the grey Benz, if you wish to change type One or Two");
        }
        else if (carName == "Quit")
        {
            Console.WriteLine("Thx for playing");
        }
        else
        {
            Console.WriteLine("What?? please type new answer");
        }

    }

    cw
    // game doesent shut down after run
    Console.ReadLine();

}