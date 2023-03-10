using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameObject RestartButton;
    public GameObject colectable1;
    public GameObject colectable2;
    public GameObject colectable3;
    public GameObject colectable4;
    public GameObject colectable5;
    public GameObject colectable6;
    public GameObject colectable7;
    public GameObject colectable8;
    public TextMeshProUGUI time;
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }



    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                time.text = "time: " + (int)timeRemaining;
            }
            else
            {   
                RestartButton.SetActive(true);
                colectable1.SetActive(false);
                colectable2.SetActive(false);
                colectable3.SetActive(false);
                colectable4.SetActive(false);
                colectable5.SetActive(false);
                colectable6.SetActive(false);
                colectable7.SetActive(false);
                colectable8.SetActive(false);
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
}