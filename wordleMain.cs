using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class wordleMain : MonoBehaviour
{
    
    string word;
    public string guessWord;
    public TextMeshProUGUI showWord;

    public wordList wordlist;

    public rowScript[] row = new rowScript[6];
    Color my_Green = new Color(0.3f, 0.8f, 0.5f, 1);
    Color my_Default = new Color(0.8f, 0.8f, 0.8f, 1f);
    Color my_Yellow = new Color(1f, 0.9f, 0.4f, 1f);

    int currentAttempt = 0;
    int maxAttempt = 6;
    int startRow = 0;
    int newRow;
    bool gameEnd, stopGame;
    IEnumerator cor;




    // if word is guessed before last row, stop input

    private void Start()
    {
        gameEnd = false;
        word = wordlist.realWord();
        showWord.enabled = false;
    }
    void Update()
    {
        
        showSecretWord();
        goToNewRow();
        keyBoardInput();
        unCheckedCompareWords();
        Debug.Log(word);

        
        
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
            row[startRow].buttons[i].text = "" + guessWord[i];
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

        if (Input.GetKeyDown(KeyCode.Return) && guessWord == word)
        {
            compareWords();

        } else if (Input.GetKeyDown(KeyCode.Return) && guessWord.Length == 5)
        {
            compareWords();
            rowNum();
            attemptNum();
            guessWord = "";
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

    // print word after failing to guess it

    void showSecretWord()
    {
        if((Input.GetKeyDown(KeyCode.Return) && startRow == 5) && guessWord != word)
        {
            // print actual word somewhere on the screen
            // TMPRO
            showWord.enabled = true;
            showWord.text = "Correct word: " + word;
        }
    }


    int forceStartRow()
    {
        
        Debug.Log("Does this work???");
        int s = startRow + 10;
        startRow = s;
        return startRow;
        
    }
    string keyBoardInput()
    {
        // this seems unbearably stupid, has to be a better solution
        string n;
        // also for loop??
        if (Input.GetKeyDown(KeyCode.A))
        {
            n = guessWord + "a";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            n = guessWord + "b";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            n = guessWord + "c";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            n = guessWord + "d";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            n = guessWord + "e";
            return guessWord = n;
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            n = guessWord + "f";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            n = guessWord + "g";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            n = guessWord + "h";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            n = guessWord + "i";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            n = guessWord + "j";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            n = guessWord + "k";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            n = guessWord + "l";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            n = guessWord + "m";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            n = guessWord + "n";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            n = guessWord + "o";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            n = guessWord + "p";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            n = guessWord + "q";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            n = guessWord + "r";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            n = guessWord + "s";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            n = guessWord + "t";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            n = guessWord + "u";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            n = guessWord + "v";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            n = guessWord + "w";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            n = guessWord + "x";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            n = guessWord + "y";
            return guessWord = n;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            n = guessWord + "z";
            return guessWord = n;
        }



        else if (Input.GetKeyDown(KeyCode.Backspace)) {

            n = guessWord.Remove(guessWord.Length - 1);
            row[startRow].buttons[n.Length].text = string.Empty;
            return guessWord = n;
        }

        removeExtraChar();
        return guessWord;
    }

    // When letters go over 5 return back to last 5 
    void removeExtraChar()
    {
        if(guessWord.Length > 4)
        {
            guessWord = guessWord.Substring(0, 5);
        }
    }

    

    // Effect for box resize after letter input

    // On screen keyboard input
    public void keyPress(string s)
    {
        string u = guessWord + s;
        guessWord = u;
    }

    // Delete function for on screen keyboard
    public void delPress()
    {
        string s = guessWord.Remove(guessWord.Length - 1);
        guessWord = s;
        row[startRow].buttons[guessWord.Length].text = string.Empty;
    }

    // Enter function for on screen keyboard
    public void enterPress()
    {
        if(guessWord.Length == 5)
        {
            compareWords();
            guessWord = string.Empty;
            rowNum();

        }
    }

    // Reload scene
    public void refreshGame()
    {
        SceneManager.LoadScene(0);
    }

}
