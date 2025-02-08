using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public int speed = 5;
    public int speed2 = 0;
    public int damage = 1;
    public int pierce = 1;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocityY = speed;
        rb.linearVelocityX = speed2;
    }

    void Update()
    {
        if (transform.position.y > 5.35)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyUnit>().TakeDamage(damage);
            pierce--;
            if (pierce <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
