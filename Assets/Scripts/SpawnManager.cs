using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] animalPrefabsLeft;
    public GameObject[] animalPrefabsRight;
    private float spawnRangeX = 20;
    private float spawnRangeZ = -7;
    private float spawnPosZ = 20;
    private float startDelay = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomAnimal", startDelay);
        Invoke("SpawnRandomAnimalLeft", startDelay);
        Invoke("SpawnRandomAnimalRight", startDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        Invoke("SpawnRandomAnimal", Random.Range(1f,2f));
    }
    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabsLeft.Length);
        Vector3 spawnPos = new Vector3(-30, 0, Random.Range(spawnRangeZ, 0));
        
        Instantiate(animalPrefabsLeft[animalIndex], spawnPos, animalPrefabsLeft[animalIndex].transform.rotation);
        Invoke("SpawnRandomAnimalLeft", Random.Range(1f, 2f));
    }
    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabsRight.Length);
        Vector3 spawnPos = new Vector3(30, 0, Random.Range(spawnRangeZ, 0));
        
        Instantiate(animalPrefabsRight[animalIndex], spawnPos, animalPrefabsRight[animalIndex].transform.rotation);
        Invoke("SpawnRandomAnimalRight", Random.Range(1f, 2f));
    }
}
