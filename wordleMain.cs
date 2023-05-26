using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class wordleMain : MonoBehaviour
{
    string word = "farts";
    public string guessWord;

    string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

    public rowScript[] row = new rowScript[6];
    Color my_Green = new Color(0.3f, 0.8f, 0.5f, 1);
    Color my_Default = new Color(0.8f, 0.8f, 0.8f, 1f);
    Color my_Yellow = new Color(1f, 0.9f, 0.4f, 1f);

    int currentAttempt = 0;
    int maxAttempt = 6;
    int startRow = 0;
    int newRow;
    bool gameEnd;

    private void Start()
    {
        gameEnd = false;
    }
    void Update()
    {
        Debug.Log(guessWord);
        goToNewRow();
        keyBoardInput();
        unCheckedCompareWords();
    }


    void compareWords()
    {

        // For loop to check char position
        for (int i = 0; i<5; i++)
        {
            row[startRow].buttons[i].text = "" + guessWord[i];

            checkLetterPos(i);
        }
    }

    void unCheckedCompareWords()
    {
        for (int i = 0; i<5;i++)
        {
            row[startRow].buttons[i].text = ""+ guessWord[i];
        }
    }

    // Check if int i = word string array in for loop
    void checkLetterPos(int i)
    {
        
        if (word[i] == guessWord[i])  // check if i == current position of string
        {
            row[startRow].blocks[i].color = my_Green;
        } else if (word.Contains(guessWord[i]))  // check if word contains guessWord characters(string)
        {
            row[startRow].blocks[i].color = my_Yellow;
        } else
        {
            row[startRow].blocks[i].color = my_Default;  // hold default color value
        }
    }

    // check if letter exists in the word
    void goToNewRow()
    {
        // string length and input
        if (guessWord.Length == 5 && Input.GetKeyDown(KeyCode.Return))  
        {            
            compareWords();
            rowNum();
            attemptNum();
            guessWord = "";
        } 
        else if (currentAttempt == maxAttempt)
        {
            gameOver();
            Debug.Log("Game Over!");
        } else if (gameOverCheck() == true && Input.GetKey(KeyCode.Return))
        {
            gameOver();
            Debug.Log("Correct Guess!");
        }
        
    }

    // Increase Row Number when word is guessed
    int rowNum()
    {
        newRow = startRow + 1;
        startRow = newRow;
        return startRow;
    }

    // Increase attempt Number when word is guessed
    int attemptNum()
    {
        int s = currentAttempt + 1;
        currentAttempt = s;
        return s;
    }

    void gameOver()
    {
        gameEnd = true;
        currentAttempt = 6;

        // lock game screen and set refresh button
    }

    bool gameOverCheck()
    {
        if(guessWord == word)
        {
            return true;
        } else
        {
            return false;
        }
    }

    string keyBoardInput()
    {

        
        // this seems unbearably stupid logic, google time
        string n;
        // also for loop??
        if (Input.GetKeyDown(KeyCode.A))
        {
            n = guessWord + "a";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            n = guessWord + "b";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            n = guessWord + "c";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            n = guessWord + "d";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            n = guessWord + "e";
            guessWord = n;
            return guessWord;
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            n = guessWord + "f";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            n = guessWord + "g";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            n = guessWord + "h";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            n = guessWord + "i";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            n = guessWord + "j";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            n = guessWord + "k";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            n = guessWord + "l";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            n = guessWord + "m";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            n = guessWord + "n";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            n = guessWord + "o";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            n = guessWord + "p";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            n = guessWord + "q";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            n = guessWord + "r";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            n = guessWord + "s";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            n = guessWord + "t";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            n = guessWord + "u";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            n = guessWord + "v";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            n = guessWord + "w";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            n = guessWord + "x";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            n = guessWord + "y";
            guessWord = n;
            return guessWord;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            n = guessWord + "z";
            guessWord = n;
            return guessWord;
        }



        else if (Input.GetKeyDown(KeyCode.Backspace)) {

            n = guessWord.Remove(guessWord.Length - 1);
            guessWord = n;
            return guessWord;
        }

        removeExtraChar();
        return guessWord;
    }


    void removeExtraChar()
    {
        if(guessWord.Length > 4)
        {
            guessWord = guessWord.Substring(0, 5);
        }
    }
}
