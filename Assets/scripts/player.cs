using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject pelaaja;
    private Rigidbody2D rb;
    private Vector2 speed = new Vector2(0.15f,0);

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity -= speed;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity += speed;
        }

        rb.velocity *= new Vector2(0.997f, 0);
    }
}
