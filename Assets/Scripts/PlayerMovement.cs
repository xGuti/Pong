using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            _rb.velocity = Vector2.up * _speed;
        else if (Input.GetKey(KeyCode.S))
            _rb.velocity = Vector2.down * _speed;
        else
            _rb.velocity = Vector2.zero;
    }
}
