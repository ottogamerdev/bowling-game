using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingPin : MonoBehaviour
{
    public Transform pin;
    public float treshhold = .6f;
    public int point = 1;
    public Score score;

    void Awake()
    {
        score = GameObject.FindWithTag("Score").GetComponent<Score>();
    }

    void CheckIfFell()
    {
        try
        {
            if (pin.up.y < treshhold)
            {
                score.Add(point);
                gameObject.GetComponent<Collider>().enabled = false;
            }
            
        }
        catch
        {
            Debug.Log("toimii");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        CheckIfFell();
    }
}
