using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;
    public Text text;

    public void Add(int amount)
    {
        score += amount;
        UpdateDisplay();

        // oma koodi, testailua jolla saisi striken toimimaan
        // ei toimi pitkässä juoksussa, pitää laittaa keiloille oma int

        if (score == 9)
        {
            score += 20;
        }
        // oma koodi loppuu
    }
    void start ()
    {
        score = 0;
    }

    void UpdateDisplay()
    {
        text.text = "score " + score;
    }
}
