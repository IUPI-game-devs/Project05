using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This implements the signleton pattern
-------------------------------------------
The singleton pattern is a design pattern 
that restricts the instantiation of a class 
to one object 
*/
public class ScoreManeger : MonoBehaviour
{
    public static ScoreManeger instance;
    public int amount;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Duplicate ScoreManeger found. Ignoring this one.", gameObject);
        }
    }

    // Start is called before the first frame update
    
}
