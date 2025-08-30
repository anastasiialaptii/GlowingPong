using UnityEngine;

public class Player2 : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Vector2 _racketDirection;
    private float _racketSpeed = 15;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var directionY = Input.GetAxisRaw("Vertical2");

        _racketDirection = new Vector2(0, directionY).normalized;
    }

    private void FixedUpdate()
    {
        _rb.linearVelocity = _racketDirection * _racketSpeed;
    }
}
