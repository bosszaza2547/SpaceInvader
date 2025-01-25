using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    public int score = 250;
    public GameManagerScript manager;
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManagerScript>();
    }

    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            manager.GetComponent<GameManagerScript>().AddScore(score);
            Destroy(gameObject);
        }
    }
}
