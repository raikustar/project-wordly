using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wordList: MonoBehaviour
{
    string[] words = {
    "which", "there", "their", "about", "would", "these", "other", "words", "could", "write", "first", "water", "after", "where", "right", "think", "three", "years", "place", "sound", "great", "again", "still", "every", "small", "found", "those", "never",
    "stony", "surge", "hurts", "repel", "dated", "dries", "mates", "sworn", "baker", "spice", "oasis", "boils", "doves", "sneak", "colon", "cacao", "boxer", "delta", "laden", "larva", "spool", "spill", "jukes", "doggo", "nerdy", "baldy", "labia"

    };


    public int rng()
    {
        int s = Random.Range(0, words.Length);
        return s;
    }

    public string realWord()
    {
        string w = words[rng()];
        return w;
    }
}
