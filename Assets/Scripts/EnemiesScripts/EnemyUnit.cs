using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyUnit : MonoBehaviour
{
    public int health = 5;
    public int damage = 1;
    public GameObject ItemPrefab;
    /*public int score = 50;
    public GameObject GameManager;
    public GameObject ItemPrefab;
    public float itemchance = 0.25f;*/
    public GameManagerScript manager;
    public float itemchance = 0.05f;
    public int score = 50;
    
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManagerScript>();
    }

    void Update()
    {
        if (health <= 0)
        {
            /*GameManager.GetComponent<GameManager>().AddScore(score);
            if (Random.Range(0f, 1f) <= itemchance)
            {
                ItemPrefab.GetComponent<Items>().GameManager = GameManager;
                Instantiate(ItemPrefab, transform.position, ItemPrefab.transform.rotation);
            }*/
            if (Random.Range(0f, 1f) <= itemchance)
            {
                Instantiate(ItemPrefab, transform.position, ItemPrefab.transform.rotation);
            }
            manager.AddScore(score);
            Destroy(gameObject);
        }
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
