using UnityEngine;

public class Items : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 0.05f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocityY = speed;
    }

    void Update()
    {
        
    }
}
