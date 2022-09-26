using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject gameOverCanvas;
    private void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 4.8 || transform.position.y < -3.1)
        {
            Time.timeScale = 0;
            gameOverCanvas.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);
    }
}
