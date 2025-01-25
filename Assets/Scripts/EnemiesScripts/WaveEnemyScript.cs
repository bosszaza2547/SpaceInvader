using UnityEngine;

public class WaveEnemyScript : MonoBehaviour
{
    public GameObject Bullet;
    public float AttackRate = 3f;
    public float FirstAttackRate = 1f;
    public int speed = 3;
    private Rigidbody2D rb;
    public float WaveStrength = 3f;
    public bool up = true;
    public float yvalue;
    void Start()
    {
        //yvalue = WaveStrength;
        Invoke("Shoot", AttackRate + Random.Range(-FirstAttackRate, FirstAttackRate));
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocityX = speed;
    }

    void Update()
    {
        if (up)
        {
            yvalue += Time.deltaTime;
        }
        else
        {
            yvalue -= Time.deltaTime;
        }
        if (yvalue >= WaveStrength)
        {
            up = false;
        }
        else if (yvalue <= -WaveStrength)
        {
            up = true;
        }
        rb.linearVelocityY = yvalue;
        if (transform.position.x > 2.7)
        {
            Destroy(gameObject);
        }
    }
    public void Shoot()
    {
        Instantiate(Bullet, transform.position, Quaternion.identity);
        Invoke("Shoot", AttackRate);
    }
}
