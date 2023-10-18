using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDeath : MonoBehaviour
{
    public int amount;
    // Start is called before the first frame update
    void OnDestroy()
    {
        ScoreManager.instance.amount += amount;
    }
}
