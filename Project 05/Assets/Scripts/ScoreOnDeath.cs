using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ScoreOnDeath : MonoBehaviour
{
    public int amount;

    void OnDestroy()
    {
        ScoreManager.instance.amount += amount;
    }
}