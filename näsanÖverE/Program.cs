using System;
using System.Collections.Generic;
ChooseCar();

void ChooseCar()
{
    // jhgmjf
    List<string> car = new List<string>();
    car.Add("Black");
    car.Add("White");
    car.Add("Grey");

    foreach (string cars in car)
    {
        Console.WriteLine(cars);
    }


    string blackCar = "One";
    Console.WriteLine("Welcome which of your 3 cars would you like to use today, 1, 2 or 3");

    string carName = "";
    int cNum = 0;

    while (carName != "Quit")
    {
        carName = Console.ReadLine();
        bool whip = int.TryParse(carName, out cNum);
        // gör om till int


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

    Console.ReadLine();

}