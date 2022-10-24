using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Rigidbody2D _rb;
    public GameObject _ball;
    [SerializeField] private int _direction;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_ball.GetComponent<Rigidbody2D>().velocity.x > 0 && _ball.transform.position.x < 7.5f)
        {
            if (_ball.transform.position.y < transform.position.y)
                _direction = -1;
            else if (_ball.transform.position.y > transform.position.y)
                _direction = 1;
            else
                _direction = 0;
        }
        else
            _direction = 0;
        _rb.velocity = Vector2.up * _direction * _speed;
    }
}
