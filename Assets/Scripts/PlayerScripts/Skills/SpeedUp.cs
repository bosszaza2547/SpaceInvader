using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public GameObject Player;
    public float cooldown = 5f;
    public float time = 0;
    public float bufftime = 5f;
    public float time2 = 0;
    public float speed = 2;
    public float playerspeed;
    public float speed2 = 2;
    public float playerspeed2;
    public GameManagerScript manager;
    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManagerScript>();
        Player = GameObject.FindGameObjectWithTag("Player");
        playerspeed = Player.GetComponent<PlayerController>().moveSpeed;
        playerspeed2 = Player.GetComponent<PlayerAttack>().AttackRate;
    }
    private void Update()
    {
        if (Input.GetKeyDown(GetComponent<SkillUseButton>().button))
        {
            if (time <= 0)
            {
                time2 = bufftime;
                time = cooldown;
            }
        }
        if (time > 0)
        {
            time -= Time.deltaTime;
            manager.SetSkillCooldown(false, GetComponent<SkillUseButton>().value);
        }
        else
        {
            manager.SetSkillCooldown(true, GetComponent<SkillUseButton>().value);
        }
        if (time2 > 0)
        {
            time2 -= Time.deltaTime;
            Player.GetComponent<PlayerController>().moveSpeed = playerspeed * speed;
            Player.GetComponent<PlayerAttack>().AttackRate = playerspeed2 / speed2;
        }
        else
        {
            Player.GetComponent<PlayerController>().moveSpeed = playerspeed;
            Player.GetComponent<PlayerAttack>().AttackRate = playerspeed2;
        }
    }
}
