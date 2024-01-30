using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TMP_Text TimerText;

    [SerializeField]
    private float delayBeforeLoading = 10f;
    [SerializeField]
    private string sceneNameToLoad;

    private float timeElapsed;

    void Start()
    {
        timeElapsed = delayBeforeLoading;
    }

    private void Update()
    {
        timeElapsed -= Time.deltaTime;

        int timerInt = (int)timeElapsed;

        TimerText.text = timerInt.ToString();

        if (timeElapsed <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
