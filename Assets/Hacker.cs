using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Accessing the main Server...");
        Terminal.WriteLine("Main Server On.");
        Terminal.WriteLine("Welcome Admin. What would you like to");
        Terminal.WriteLine("access today ?");
        Terminal.WriteLine("Press 1 for YouTube");
        Terminal.WriteLine("Press 2 for the Video Game Archive");
        Terminal.WriteLine("Press 3 for Nebula Tales");
        Terminal.WriteLine("Enter your selection :");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
