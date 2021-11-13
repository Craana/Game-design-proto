using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIfunctions : MonoBehaviour
{
    [SerializeField] private Text pointsText;
    [SerializeField] private Text combopointsText;
    [SerializeField] private Text timeText;
    private float startTime;
    int scorePoints;

    private void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        DisplayTime();
        DisplayScore();
        DisplayCombo();
    }

    void DisplayTime()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("F2");

        timeText.text = minutes + ":" + seconds;
    }

    void DisplayScore()
    {
        pointsText.text = "Score: " + scorePoints.ToString();
    }

    public void AddScore()
    {
        scorePoints++;
    }

    void DisplayCombo()
    {

    }

}
