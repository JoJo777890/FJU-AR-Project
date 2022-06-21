using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawn : MonoBehaviour
{
    private Transform SpawnPoints;
    public GameObject Sphere;

    void Start () {

        SpawnPoints = GameObject.Find("StageParent").transform;
        Debug.Log(SpawnPoints);

        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning () {
        yield return new WaitForSeconds(1);

        Instantiate(Sphere, SpawnPoints.position, Quaternion.identity);

        StartCoroutine(StartSpawning());
    }
}
