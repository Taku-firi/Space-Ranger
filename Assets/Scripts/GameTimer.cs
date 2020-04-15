using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public TextMeshProUGUI Timer;
    int minute;
    int second;
    float timespend;

    // Update is called once per frame
    void Update()
    {
        timespend = Time.timeSinceLevelLoad;

        minute = (int)timespend / 60;
        second = (int)timespend - minute * 60;

        Timer.text = "T: "+ string.Format("{0:D2}:{1:D2}", minute, second);
    }
}
