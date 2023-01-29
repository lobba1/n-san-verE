using System;
using System.Collections.Generic;
ChooseCar();

void ChooseCar()
{
    // skapa string som heter "car", med 3 element 
    List<string> car = new List<string>();
    car.Add("Black");
    car.Add("White");
    car.Add("Grey");
    // foreach är en loop som körs och skriver elementen till consolen
    foreach (string cars in car)
    {
        Console.WriteLine(cars);
    }

    // välkommnar spelaren och ber spelare välja bil
    string blackCar = "One";
    Console.WriteLine("Welcome which of your 3 cars would you like to use today, 1, 2 or 3");
    // varar spelares svar
    string carName = "";
    int cNum = 0;
    // kör loop tills spelaren skriver "Quit"
    while (carName != "Quit")
    {
        //läser användares svar
        carName = Console.ReadLine();
        bool whip = int.TryParse(carName, out cNum);
        // gör om till int och förvarar i "cNum"

    // Kollar spelarens svar och skriver respoons beroende på vad spelaren skriver
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
    // så att spelet inte stängs ner
    Console.ReadLine();

}