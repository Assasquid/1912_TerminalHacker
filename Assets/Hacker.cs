using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    public string greeting = "Welcome Admin.";
    int level;

    void Start()
    {
        ShowMainMenu();
    }

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
        Terminal.WriteLine("Type 'menu' to go back.");
        Terminal.WriteLine("Enter your selection :");
    }

    void OnUserInput(string input)
    {
        print("Player '" + input + "'");
        if (input == "1")
        {
            Terminal.WriteLine("You chose YouTube.");
            level = 1;
        }

        else if (input == "2")
        {
            Terminal.WriteLine("You chose Video Game Archive.");
            level = 2;
        }

        else if (input == "3")
        {
            Terminal.WriteLine("You chose Nebula Tales.");
            level = 3;
        }

        else if (input == "menu")
        {
            ShowMainMenu();
        }

        else if (input == "woomy")
        {
            Terminal.WriteLine("Agent 3, is that you ?");
        }

        else if (input == "evilsquid")
        {
            Terminal.WriteLine("Qui pour un Poulpe Garou?");
        }

        else if (input == "leo paul")
        {
            Terminal.WriteLine("Previously in the LPCU...");
        }

        else if (input == "octoboy")
        {
            Terminal.WriteLine("Leo est un Poulpe Garou.");
        }

        else if (input == "banana croissant")
        {
            Terminal.WriteLine("Mmmmm YUMMY !");
        }

        else if (input == "anticonstitutionnellement")
        {
            Terminal.WriteLine("Gladio ? C'est toi ?");
        }

        else if (input == "code createur")
        {
            Terminal.WriteLine("Salut ChickenGod !");
        }

        else
        {
            Terminal.WriteLine("Please type a valid command.");
        }
    }

    void StartGame()
    {
        Terminal.WriteLine("You have chosen level " + level);
    }

}
