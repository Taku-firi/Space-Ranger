using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    private static Counter _instance;
    
    public static Counter Instance
    {
        get
        {
            if (_instance != null)
                return _instance;
            else
            {
                return null;
            }
        }
    }

    
    public TextMeshProUGUI DebrisText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI IpGroupText;
    public TextMeshProUGUI RgbGroupText;
    public TextMeshProUGUI RedGroupText;
    public TextMeshProUGUI GreenGroupText;
    public TextMeshProUGUI BlueGroupText;
    public int DebrisDestroyed;
    public int Score;
    public int IpGroup;
    public int RgbGroup;
    public int RedG;
    public int GreenG;
    public int BlueG;


    void Awake()
    {
        _instance = this;
        DebrisDestroyed = 0;
        Score = 0;
        IpGroup = 0;
        RgbGroup = 0;
        RedG = 0;
        GreenG = 0;
        BlueG = 0;
    }

    public void AddDH()
    {
        DebrisText.text = "DH: " + ++DebrisDestroyed;
    }

    public void AddScore(int s)
    {
        Score += s;
        ScoreText.text = "S: " + Score;
    }

    public void AddIpGroup()
    {
        IpGroupText.text = "IPG: " + ++IpGroup;
    }

    public void AddRgbGroup()
    {
        RgbGroupText.text = "RGB: " + ++RgbGroup;
    }

    public void AddColorGroup(string color)
    {
        switch (color)
        {
            case "Red":
                RedGroupText.text = "R: " + ++RedG;
                break;
            case "Green":
                GreenGroupText.text = "G: " + ++GreenG;
                break;
            case "Blue":
                BlueGroupText.text = "B: " + ++BlueG;
                break;
        }
    }
    public int GetScore()
    {
        return Score;
    }
}
