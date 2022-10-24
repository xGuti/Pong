using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int playerScore = 0;
    public static int oponentScore = 0;

    public GameObject _MenuCanvas;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void Play()
    {
        _MenuCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
