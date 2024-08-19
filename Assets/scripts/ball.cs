using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public Text scoredisplay;
    private long score;
    public Text wintext;
    public Text losetext;

    private int xspeed;
    private int yspeed;

    private int maxvelocity = 10;
    private int sqrMaxVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        xspeed = Random.Range(-5, 5);
        yspeed = Random.Range(-5, 5);

        rb.velocity = new Vector3(xspeed, -yspeed);
    }
    private void Update()
    {
        sqrMaxVelocity = maxvelocity * maxvelocity;
        if (rb.velocity.sqrMagnitude > sqrMaxVelocity)
        {
            rb.velocity = rb.velocity.normalized * maxvelocity;
        }
    }
    public float speed = 2.0f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("brick"))
        {
            Destroy(collision.gameObject);
            score += 7397812045;
            scoredisplay.text = "Score: " + score;

            if (score >= 266321233620)
            {
                Destroy(gameObject);
                wintext.enabled = true;
            }
        }

        if (collision.collider.CompareTag("floor"))
        {
            Destroy(gameObject);
            losetext.enabled = true;
            Time.timeScale = 0;
        }
    }

}