using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveSpawner2 : MonoBehaviour
{
    public enum SpawnState { SPAWNING, WAITING, COUNTING};
    [System.Serializable]
 public class Wave
    {

        public string name;
        public Transform enemy;
        public int count;
        public float rate;
    }
    public Wave[] waves;
    private int nextWave = 0;

    public float timeBetweenWaves = 5f;
    public float waveCountDown;
    private float searchCountdown;

    public SpawnState state = SpawnState.COUNTING;
     void Start()
    {
        waveCountDown = timeBetweenWaves;
    }
    void Update()
    {
       
        if (state == SpawnState.WAITING)
        {
            if (!EnemyIsAlive())
            {
                WaveCompleted();
            }
            else
            {
                return;
            }
        }
       if (waveCountDown <=0)
        {
            if (state != SpawnState.SPAWNING)
            {
                StartCoroutine(SpawnWave(waves[nextWave]));
            }




        }
       else
       {
           waveCountDown -= Time.deltaTime;
       }
    }
    void WaveCompleted ()
    {
        state = SpawnState.COUNTING;
        waveCountDown = timeBetweenWaves;

        if(nextWave + 1> waves.Length - 1)
        {
            nextWave = 0;

        }

        nextWave++;
    }

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;
            if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
            {
                return false;

            }
        }
     
        return true;
    }
    IEnumerator SpawnWave(Wave _wave)
    {

        state = SpawnState.SPAWNING;
        for(int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f/ _wave.rate );
        }

        state = SpawnState.WAITING;

        yield break;

    }
    void SpawnEnemy(Transform _enemy)
    {
        Instantiate(_enemy, transform.position, transform.rotation);
        Debug.Log("Spawing Enmey: " + _enemy.name);
    }

}
