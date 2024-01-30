using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoremanager : MonoBehaviour
{
    public int CurrentScore = 0;
    public scoregui _scoregui;
    public void coinscollected(int amount)
    { 
        if (_scoregui == null)
        {
            Debug.LogWarning("missing score GUI, please make sure to hook the correct TM_Pro");
            return;
        }

        CurrentScore += amount;

        _scoregui.UpdateScore(CurrentScore);
        Debug.Log("Current Score " + CurrentScore);
    }
}
