using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    private int Score;
    private int Wave;
    private int Health,MaxHealth;
    public GameObject UI;
    public GameObject Pause;
    public GameObject[] SkillUI;


    void Start()
    {
        Time.timeScale = 1;
        for (int i = 0; i < SkillUI.Length; i++)
        {
            SkillUI[i].GetComponent<Image>().sprite = Globalvariable.SkillSprite[Globalvariable.SelectedSkills[i]];
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(!Pause.activeSelf)
                Pause.GetComponent<PauseMenu>().Pause();
            else
                Pause.GetComponent<PauseMenu>().Unpause();
        }
    }
    public void UpdateScore()
    {
        UI.transform.Find("UIBackground").transform.Find("Score").transform.Find("Score Value").gameObject.GetComponent<TextMeshProUGUI>().text = Score.ToString();
    }
    public void AddScore(int value)
    {
        Score += value;
        UpdateScore();    
    }
    public void SetScore(int value)
    {
        Score = value;
        UpdateScore();
    }
    public void UpdateWave()
    {
        UI.transform.Find("UIBackground").transform.Find("Wave").transform.Find("Wave Value").gameObject.GetComponent<TextMeshProUGUI>().text = Wave.ToString();
    }
    public void SetWave(int value)
    {
        Wave = value;
        UpdateWave();
    }
    public void UpdateHealth()
    {
        UI.transform.Find("UIBackground").transform.Find("Health").transform.Find("Health Value").gameObject.GetComponent<TextMeshProUGUI>().text = Health.ToString() + " / " + MaxHealth.ToString();
    }
    public void SetHealth(int value)
    {
        Health = value;
        UpdateHealth();
    }
    public void UpdateMaxHealth(int value)
    {
        MaxHealth = value;
        UpdateHealth();
    }
    public void SetSkillCooldown(bool value, int i)
    {
        if(value == true) 
            SkillUI[i].GetComponent<Image>().color = new Color32(255,255,255,255);
        else
            SkillUI[i].GetComponent<Image>().color = new Color32(100, 100, 100, 255);
    }
    
}
