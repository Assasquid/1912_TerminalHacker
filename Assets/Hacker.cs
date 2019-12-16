using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game configuration data
    string[] level1Passwords = {"video", "creator", "like", "dislike", "live" };
    string[] level2Passwords = { "multiplayer", "narrative", "platformer", "controller", "cooperation" };
    string[] level3Passwords = { "user experience", "game design", "communication", "storytellers", "game development" };


    //Game state
    public string greeting = "Welcome Admin.";
    int level;
    enum Screen { MainMenu, Password, Win }
    Screen currentScreen;
    string password;



    void Start()
    {
        print(level1Passwords[0]);
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
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
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

        else if (input == "pire")
        {
            Terminal.WriteLine("'Moi c'est pire !' - Darksquid 2019");
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
        Terminal.ClearScreen();
        switch (level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level1Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            default:
                Debug.LogError("Invalid level number.");
                break;
        }
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
