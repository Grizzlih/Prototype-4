using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    float spawnRange = 9;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, GenerateRandomPosition(), enemyPrefab.transform.rotation);
    }

    Vector3 GenerateRandomPosition()
    {
        float startPosX = Random.Range(-spawnRange, spawnRange);
        float startPosY = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(startPosX, 0, startPosY);
        return randomPos;
    }
}
