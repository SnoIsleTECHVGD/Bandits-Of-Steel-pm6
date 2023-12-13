using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emenySpawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1f;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private bool canSpawn = true;
    [SerializeField] private float waitSpawn;
    [SerializeField] private float decreaseSpawnRateTimer;
    private void DecreaseSpawnSpeed()
    {
        spawnRate *= .9f;
    }

    private void Start()
    {
        InvokeRepeating(nameof(DecreaseSpawnSpeed), waitSpawn, decreaseSpawnRateTimer);
        StartCoroutine(Spawner());
    }
    private IEnumerator Spawner()
    {
        while (canSpawn)
        {
            yield return new WaitForSeconds(spawnRate);

            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }
}
