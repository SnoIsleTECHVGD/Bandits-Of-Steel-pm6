using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
     [System.Serializable]
    public class WaveContent
    {
        [SerializeField] [NonReorderable] GameObject[] monsterSpawn;

        public GameObject[] GetMonsterSpawnList()
        {
            return monsterSpawn;
        }
    }
    [SerializeField][NonReorderable] WaveContent[] waves;
    int currentWave = 0;
    float spawnRange = 10;
    public List<GameObject> currentMonster;
    void Start()
    {
        SpawnWave();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnWave()
    {
        
       for(int i = 0; i < waves[currentWave].GetMonsterSpawnList().Length; i++)
        {
            Instantiate(waves[currentWave].GetMonsterSpawnList()[i],FindSpawnLoc(),Quaternion.identity);
          
        }
    }

    Vector3 FindSpawnLoc()
    {
        Vector3 SpawnPos;

        float xLoc = Random.Range(-spawnRange, spawnRange) + transform.position.x;
        float zLoc = Random.Range(-spawnRange, spawnRange) + transform.position.z;
        float yLoc = transform.position.y;

        SpawnPos = new Vector3(xLoc, yLoc, zLoc);
  

        if(Physics2D.Raycast(SpawnPos, Vector3.down,5))
        {
            return SpawnPos;
        }
        else
        {
           return FindSpawnLoc();
        }
    }
}
