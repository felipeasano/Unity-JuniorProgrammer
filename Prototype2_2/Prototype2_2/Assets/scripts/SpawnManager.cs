using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //public int animalIndex;
    private float spawnRangeX = 10;
    private float spawnRangeZ = 20;
    private float spawnLR = 20;
    
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        // Metodo de repeticao em intervalos
        // parametros: o que sera invocado, momento de inicio, intervalo de repeticao
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

        // Spawn animas from the left side
        InvokeRepeating("SpawnLeftAnimal", startDelay +1, spawnInterval +2);

        // Spawn animals from the right side
        InvokeRepeating("SpawnRightAnimal", startDelay +2, spawnInterval +1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // metodo para criar objetos num intervalo de espaco de modo aleatorio
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spawnLR, 0, Random.Range(-spawnLR, spawnLR));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnLR, 0, Random.Range(-spawnLR,spawnLR));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}
