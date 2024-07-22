using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    private float spawnRate = 2f;

    void Start()
    {
        StartCoroutine(SpawnEnemy(spawnRate, enemyPrefab));
    }

    private IEnumerator SpawnEnemy(float spawnRate, GameObject enemyPrefab)
    {

        int x;
        int randomY = Random.Range(-60, 60);

        int leftOrRight = Random.Range(0, 2);

        if (leftOrRight == 0)
        {
            x = -100;
        } else
        {
            x = 100;
        }

        yield return new WaitForSeconds(spawnRate);
        Instantiate(enemyPrefab, new Vector2(x, randomY), Quaternion.identity);

        StartCoroutine(SpawnEnemy(spawnRate, enemyPrefab));
    }
}
