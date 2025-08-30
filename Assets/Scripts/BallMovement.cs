using System.Collections;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float _startSpeed = 4;
    private float _extraSpeed = 1;
    private float _maxExtraSpeed = 5;
    private int _hitCounter = 0;
    
    public bool isPlayer1Starting = true;

    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        StartCoroutine(Launch());
    }
    private void RestartBall()
    {
        _rb.linearVelocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0); 
    }

    public IEnumerator Launch()
    {
        RestartBall();

        yield return new WaitForSeconds(1);

        if (isPlayer1Starting)
        {
            MoveBall(new Vector2(-1, 0));
        }
        else
        {
            MoveBall(new Vector2(1, 0));
        }
    }

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        var ballSpeed = _startSpeed + _hitCounter * _extraSpeed;

        _rb.linearVelocity = direction * ballSpeed;
    }

    public void IncreaseHitCounter()
    {
        if (_hitCounter * _extraSpeed < _maxExtraSpeed)
        {
            _hitCounter++;
        }
    }
}
