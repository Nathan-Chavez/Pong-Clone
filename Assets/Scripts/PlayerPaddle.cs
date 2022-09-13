using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    private void Update()
    {
        if (Input.GetButtonDown("Vertical"))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction =  Vector2.zero;
        }
    }

     private void fixedUpdate()
        {
            if (_direction.sqrMagnitude != 0 )
            {
                _rigidbody.AddForce(_direction * this.speed);
            } 
        }
}
