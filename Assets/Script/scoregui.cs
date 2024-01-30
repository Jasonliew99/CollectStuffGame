using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoregui : MonoBehaviour
{

    public TMP_Text Scoregui;

    public void UpdateScore(int score)
    {
        if (Scoregui == null)
            return;

        Scoregui.text = "Score: " + score.ToString();
    }
}
