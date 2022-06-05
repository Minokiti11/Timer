using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public TextMeshProUGUI txt2;
    public float time = 0f;
    public bool start = false;

    public double t;

    DateTime dt;

    void Update()
    {
        if (start)
        {
            time += (Time.deltaTime);
            t = Math.Floor(time / 60);
        }
        else
        {
            time = 0f;
        }
        dt = DateTime.Now;
        txt.text = dt.ToString("yyyy/MM/dd HH:mm:ss");
        txt2.text = t.ToString("0m");
    }

    public void StartTimer()
    {
        start = true;
        
    }

    public void StopTimer()
    {
        start = false;
    }
}
