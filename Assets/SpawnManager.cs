using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;       // Array of animal prefabs to spawn
    private float spawnRangeX = 16f;         // Range on the X-axis for random spawn
    private float startDelay = 2f;           // Time before first spawn
    private float spawnInterval = 1.5f;      // Time between spawns

    void Start()
    {
        // Repeatedly call SpawnRandomAnimal starting after startDelay and repeating every spawnInterval
        InvokeRepeating(nameof(SpawnRandomAnimal), startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        // Pick a random index from the array
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Pick a random spawn position along the X-axis
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, 20);

        // Spawn the prefab at the chosen position with its original rotation
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}