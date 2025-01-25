using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject Bullet;
    public float AttackRate = 0.5f;
    void Start()
    {
        InvokeRepeating("Shoot", 0, AttackRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shoot()
    {
        Instantiate(Bullet, transform.position, Quaternion.identity);
    }
}
