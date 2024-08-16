using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public Text scoredisplay;
    private long score;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(5, -5);
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
                Debug.Log("VOITIT :D");
                Destroy(gameObject);
            }
        }
        if (collision.collider.CompareTag("floor"))
        {
            Destroy(gameObject);
            Debug.Log("HÄVISIT PALL O MENI MAAHANs");
        }
    }

}