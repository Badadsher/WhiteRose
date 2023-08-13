using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlaneSpawn : MonoBehaviour
{

    [SerializeField] private int spawnCount;
    [SerializeField] private float spawnDelay;
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private float minYValue;
    [SerializeField] private float maxYValue;
    void Start()
    {
        StartCoroutine(SpawnObjectDelayed());
    }
    IEnumerator SpawnObjectDelayed()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            yield return new WaitForSeconds(spawnDelay);
            Vector3 position = new Vector3(transform.position.x, Random.Range(minYValue, maxYValue), transform.position.z);
            Instantiate(objectToSpawn, position, transform.rotation);
        }
    }
}




