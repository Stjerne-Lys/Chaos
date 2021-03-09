using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalSpawner : MonoBehaviour
{
    public GameObject[] crystalPrefabs;
    public int crystalIndex;
    //private float spawnRangeX = 20;
    //private float spawnPosZ = 10;
    public int xPos;
    public int zPos;
    public int crystalCount;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CrystalSpawn());
        //InvokeRepeating("SpawnRandomCrystal", startDelay, spawnInterval);
    }

    
    IEnumerator CrystalSpawn()
    {
        while (crystalCount < 20)
        {
            xPos = Random.Range(-40, 15);
            zPos = Random.Range(-10, 20);
            Instantiate(crystalPrefabs[crystalIndex], new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(3f);
            crystalCount += 1;
        }
    } //https://www.youtube.com/watch?v=ydjpNNA5804&t=466s

    // Update is called once per frame
    void Update()
    {
     
    }

    void SpawnRandomCrystal()
    {
        //Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
            //0, spawnPosZ);
        //int crystalIndex = Random.Range(0, crystalPrefabs.Length);

        //Instantiate(crystalPrefabs[crystalIndex], spawnPos,
        //crystalPrefabs[crystalIndex].transform.rotation);
    }
}
