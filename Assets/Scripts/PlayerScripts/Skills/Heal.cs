using UnityEngine;

public class Heal : MonoBehaviour
{
    public GameObject Player;
    public float cooldown = 5f;
    public float time = 0;
    public GameManagerScript manager;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManagerScript>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(GetComponent<SkillUseButton>().button))
        {
            if(time <=0)
            {
                Player.GetComponent<PlayerController>().TakeDamage(-1);
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
    }
}
