using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddScore : MonoBehaviour
{
    public GameObject _ball;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_ball.transform.position.x < 0)
            GameManager.oponentScore++;
        else
            GameManager.playerScore++;
        SceneManager.LoadScene(0);
    }
}
