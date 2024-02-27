using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab; 
    public float spawnInterval = 2f; 
    public int maxEnemies = 5; 
    [SerializeField] Transform spawnPosition;
    [SerializeField] int enemyType = 0;


    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        GameObject enemy = PoolManager2.Instance.GetPooledObjects(enemyType, spawnPosition.position, spawnPosition.rotation);
            
        if(enemy != null)
            {   
            enemy.SetActive(true);
            }
            else 
            {
            Debug.LogError("Pool demasiado pequeño");
            }       
 
    }



}
