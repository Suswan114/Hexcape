using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class spawner : MonoBehaviour
{
    float spawnRate=1f;
    public GameObject hexagonPrefab;
    private float nextTimeToSpawn;
    private void Start()
    {
        nextTimeToSpawn = Time.time + 2f;
    }
    void Update()
    {
        if (Time.time > nextTimeToSpawn)
        {
            if (Time.timeScale == 1)
            {
               Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + 1f / spawnRate;
            }
        }
    }
}