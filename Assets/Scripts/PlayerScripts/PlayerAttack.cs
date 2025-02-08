using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject Bullet;
    public float AttackRate = 0.5f;
    public float time = 0;

    // Update is called once per frame
    void Update()
    {
        if(time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            Shoot();
            time = AttackRate;
        }
    }
    public void Shoot()
    {
        Bullet.GetComponent<PlayerBullet>().speed2 = 0;
        Instantiate(Bullet, transform.position, Quaternion.identity);
    }
}
