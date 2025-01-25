using UnityEngine;

public class BasicRangedEnemyScript : MonoBehaviour
{
    public GameObject Bullet;
    public float AttackRate = 2f;
    public float FirstAttackRate = 2f;
    public float RetreatTimer = 10f;
    public int speed = 3;
    private Rigidbody2D rb;
    private bool retreat = false;
    void Start()
    {
        Invoke("Shoot", AttackRate + Random.Range(-FirstAttackRate,FirstAttackRate));
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocityY = -speed;
        Invoke("Retreat", RetreatTimer);
    }

    void Update()
    {
        if (transform.position.y < 3.5 && !retreat)
        {
            rb.linearVelocityY = 0;
        }
        if (transform.position.y > 8)
        {
            Destroy(gameObject);
        }
    }
    public void Shoot()
    {
        if (transform.position.y < 3.5)
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
        Invoke("Shoot", AttackRate);
    }
    public void Retreat() 
    {
        rb.linearVelocityY = speed;
        retreat = true;
    }
}
