using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;
    [SerializeField]
    private float _spawnInterval;
    [SerializeField] private float _spawnRadius = 7;

    void Start()
    {
        StartCoroutine(SpawnEnemy(_spawnInterval, _enemyPrefab));
    }

    void Update()
    {

    }

    private IEnumerator SpawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        Vector2 spawnPos = gameObject.transform.position;
        spawnPos += Random.insideUnitCircle.normalized * _spawnRadius;
        //GameObject newEnemy = Instantiate(enemy, transform.position, Quaternion.identity);
        //GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-25f, 25), Random.Range(-26f, 26), 0), Quaternion.identity);
        GameObject newEnemy = Instantiate(enemy, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnEnemy(interval, enemy));
    }
}
