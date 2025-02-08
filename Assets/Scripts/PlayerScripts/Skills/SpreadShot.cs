using UnityEngine;

public class SpreadShot : MonoBehaviour
{
    public GameObject Player;
    public float cooldown = 5f;
    public float time = 0;
    public float time2 = 0;
    public GameObject Bullet;
    public float AttackRate = 0.5f;
    public int counts = 5;
    public int count = 0;
    public int bullets = 2;
    public GameManagerScript manager;
    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManagerScript>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (Input.GetKeyDown(GetComponent<SkillUseButton>().button))
        {
            if(time <=0)
            {
                count = counts;
                time = cooldown;
            }
        }
        if(time > 0)
        {
            time -= Time.deltaTime;
            manager.SetSkillCooldown(false, GetComponent<SkillUseButton>().value);
        }
        else
        {
            manager.SetSkillCooldown(true, GetComponent<SkillUseButton>().value);
        }
        if (count > 0 && time2 <= 0)
        {
            Shoot();
            count--;
            time2 = AttackRate;
        }
        if(time2 > 0)
        {  
            time2 -= Time.deltaTime;
        }
    }

    public void Shoot()
    {
        for (int i = 0; i < bullets; i++)
        {
            if( i == 0 )
            {
                Bullet.GetComponent<PlayerBullet>().speed2 = 0;
                Instantiate(Bullet, Player.transform.position, Quaternion.identity);
            }
            else
            {
                if ((i % 2) == 0)
                {
                    Bullet.GetComponent<PlayerBullet>().speed2 = /*(i-1)*5*/ 25/bullets  * (i-1);
                    Instantiate(Bullet, Player.transform.position, new Quaternion(0, 0, 45, (i-1) * 45 / bullets));
                }
                else
                {
                    Bullet.GetComponent<PlayerBullet>().speed2 = 25 / bullets * (-i);
                    Instantiate(Bullet, Player.transform.position, new Quaternion(0, 0, -45, i * 45 / bullets));
                }
            }

        }
    }
}
