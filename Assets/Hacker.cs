using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    public string greeting = "Welcome Admin.";

    //Comments starting with GDT are the way GDT wrote the code in their course.

    void Start()
    {
        //GDT - ShowMainMenu("Welcome Admin.");
        ShowMainMenu();
    }

    //GDT - void ShowMainMenu(string greeting)
    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Accessing the main Server...");
        Terminal.WriteLine("Main Server On.");
        Terminal.WriteLine("What would you like to");
        Terminal.WriteLine("access today ?");
        Terminal.WriteLine("Press 1 for YouTube");
        Terminal.WriteLine("Press 2 for the Video Game Archive");
        Terminal.WriteLine("Press 3 for Nebula Tales");
        Terminal.WriteLine("Enter your selection :");
    }

    void OnUserInput(string input)
    {
        print("Player '" + input + "'");
    }

}
