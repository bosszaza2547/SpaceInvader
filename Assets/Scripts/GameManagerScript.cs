using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManagerScript : MonoBehaviour
{
    private int Score;
    private int Wave;
    private int Health,MaxHealth;
    public GameObject UI;

    
    void Start()
    {
        
    }

    void Update()
    {
        
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
}
