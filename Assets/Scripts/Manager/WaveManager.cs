using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public GameObject[] Spawner;
    public GameObject[] MiniBoss;
    public GameObject[] Boss;
    public GameManagerScript manager;
    public GameObject BasicEnemySpawner;
    public int wave = 0;
    public float WaveTimer = 10;
    public int minSpawn = 3, maxSpawn = 8;
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManagerScript>();
        Invoke("NextWave", 3);
    }

    void Update()
    {
        
    }
    public void NextWave()
    {
        if (wave % 10 == 9 && Boss.Length != 0)
        {
            int random = Random.Range(0, Boss.Length);
            Instantiate(Boss[random]);

        }
        else if (wave % 5 == 0 && MiniBoss.Length != 0) 
        {
            int random = Random.Range(0, MiniBoss.Length);
            Instantiate(MiniBoss[random]);
        }
        else
        {
            int random = Random.Range(0, Spawner.Length);
            int random2 = Random.Range(minSpawn, maxSpawn);
            Spawner[random].GetComponent<SpawnCount>().Count = random2;
            //Spawner[random].GetComponent<SpawnCount>().SetCount(random2);
            Instantiate(Spawner[random]);
            if ((Boss == null || MiniBoss == null )&& wave != 0) 
            {
                Invoke("NextWave", WaveTimer);
            }
            else if(wave % 10 == 8 && wave != 0)
            {
                BasicEnemySpawner.SetActive(false);
            }
            else if (wave % 5 == 0 && wave != 0)
            {

            }
            else
            {
                Invoke("NextWave", WaveTimer);
            }
            
        }
        wave++;
        manager.SetWave(wave);
    }
}
