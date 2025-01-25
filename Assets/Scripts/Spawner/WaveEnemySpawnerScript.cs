using UnityEngine;

public class WaveEnemySpawnerScript : MonoBehaviour
{
    public GameObject WaveEnemyPrefab;
    public float delay = 1;
    public float count = 5;
    void Start()
    {
        count = gameObject.GetComponent<SpawnCount>().Count;
        for (int i = 0; i < count; i++) 
        {
            Invoke("Spawn", delay*i);
            if (i == count -1)
            {
                Invoke("DestroySelf", delay * i);
            }
        }
    }

    void Update()
    {

    }
    private void Spawn()
    {
        Instantiate(WaveEnemyPrefab, new Vector3(-9.5f, 2.2f, 0), transform.rotation);
    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
