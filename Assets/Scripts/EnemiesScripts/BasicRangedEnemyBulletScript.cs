using UnityEngine;

public class BasicRangedEnemyBulletScript : MonoBehaviour
{
    public int speed = 3;
    public int damage = 1;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocityY = -speed;
    }

    void Update()
    {
        if (transform.position.y <= -5.3 || transform.position.y >= 5.3)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerController>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
