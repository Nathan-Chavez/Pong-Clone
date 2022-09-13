using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D _rigidbody;
    public Vector3 startPosition;

    public float movement;

    void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
      
      _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, movement * speed);
    }

    public void Reset()
    {
        _rigidbody.velocity = Vector2.zero;
        transform.position = startPosition;
    }

}
