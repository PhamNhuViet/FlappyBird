using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highscore;
    public void Update()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }
}
