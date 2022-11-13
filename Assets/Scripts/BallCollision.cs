using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioManager audioManager = FindObjectOfType<AudioManager>();
        switch (collision.collider.name)
        {
            case "Player" or "Oponent":
                audioManager.Play("pallet");
                break;
            case "Bound":
                audioManager.Play("bound");
                break;
        }
    }
}
