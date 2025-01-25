using System;
using UnityEngine;

public class NonBossEnemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerController>().TakeDamage(gameObject.GetComponent<EnemyUnit>().damage);
            gameObject.GetComponent<EnemyUnit>().health = 0;
        }
    }
}
