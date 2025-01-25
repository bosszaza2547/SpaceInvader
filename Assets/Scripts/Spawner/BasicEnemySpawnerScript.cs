using UnityEngine;

public class BasicEnemySpawnerScript : MonoBehaviour
{
    public GameObject BasicMeleeEnemy;
    public GameObject BasicRangeEnemy;
    public float delay = 2;
    public float minrange = -8.3f, maxrange = 1.6f;
    public float BasicMeleeChance = 75f;
    void Start()
    {
        Invoke("Spawn", delay);
    }

    void Update()
    {
        
    }
    public void Spawn()
    {
        float randomtype = Random.Range(1f, 100f);
        if (randomtype <= BasicMeleeChance)
        {
            Instantiate(BasicMeleeEnemy, new Vector3(Random.Range(minrange, maxrange), transform.position.y, 0), transform.rotation);
        }
        else
        {
            Instantiate(BasicRangeEnemy, new Vector3(Random.Range(minrange, maxrange), transform.position.y, 0), transform.rotation);
        }
        Invoke("Spawn", delay);
    }
}
