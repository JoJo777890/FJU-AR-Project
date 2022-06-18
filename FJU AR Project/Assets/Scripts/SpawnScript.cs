using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject[] Baloons;

    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning() {
        yield return new WaitForSeconds(4);

		for (int i = 0; i < Baloons.Length; i++) {

            Instantiate(Baloons[i], SpawnPoints[i].position, Quaternion.identity);
		}

        StartCoroutine(StartSpawning());
	}
}
