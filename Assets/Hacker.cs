﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    public string greeting = "Welcome Admin.";
    int level;
    enum Screen { MainMenu, Password, Win }
    Screen currentScreen;
    string password;



    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
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
        if (input == "menu") // We can always go direct to main menu.
        {
            ShowMainMenu();
        }

        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }

        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = "video";
            StartGame();
        }

        else if (input == "2")
        {
            level = 2;
            password = "narrative";
            StartGame();

        }

        else if (input == "3")
        {
            level = 3;
            password = "game design";
            StartGame();
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
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password.");
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("WELL DONE !");
        }

        else 
        {
            Terminal.WriteLine("Wrong Password.");
        }
    }

}
