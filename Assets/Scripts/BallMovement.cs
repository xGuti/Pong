using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] private Vector2 _direction; //Serialize just for tests
    private Rigidbody2D _rb;
    private IEnumerator _coroutine;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        float x = 1;
        float y = 1;

        x = Random.Range(0, 2) == 0 ? x : -x;   //defininf sense
        y = Random.Range(0, 2) == 0 ? y : -y;   //defininf sense

        _direction = new Vector2(x, y); // inne zakresy

        _rb.velocity = _direction * _speed;

        _coroutine = speedUp(10f);
        StartCoroutine(_coroutine);
    }

    private void Update()
    {
        if (_speed >= 15)
            StopCoroutine(_coroutine);
    }

    IEnumerator speedUp(float timer)
    {
        while (true)
        {
            yield return new WaitForSeconds(timer);
            _rb.velocity /= _speed;
            _speed++;
            _rb.velocity *= _speed;

        }
    }
}
