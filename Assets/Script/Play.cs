﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene(1);
    }
    public void returnMenu()
    {
        SceneManager.LoadScene(0);
    }
}
