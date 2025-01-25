using UnityEngine;

public class BasicMeleeEnemyScript : MonoBehaviour
{
    public int speed = 3;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocityY = -speed;
    }

    void Update()
    {
        if (transform.position.y < -5.3)
        {
            Destroy(gameObject);
        }
    }
}
