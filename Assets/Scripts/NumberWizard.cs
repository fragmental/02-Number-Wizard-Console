using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;

    void Start()
    {
        StartGame();


    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me");



        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is" + min);

        print("Is the number higher or lower that " + guess + "?");
        print("Up = higher, down = lower, return = equal");
        //max = max + 1;
        if (false)
            print("stupid");
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //print("Up arrow pressed");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //print("Down arrow pressed");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            print("Play Again.");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Is the number higher or lower that " + guess + "?");
        print("Up = higher, down = lower, return = equal");
    }
}
