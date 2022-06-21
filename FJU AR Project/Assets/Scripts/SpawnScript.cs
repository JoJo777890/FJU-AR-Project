using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public int difficulty = 3;
    public int roundsPerDifficulty = 3;

    public Vector3 randomSpawnPoints;
    public GameObject[] Baloons;

    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning() {

		for (int i = 0; i < roundsPerDifficulty; i++) {

            for (int j = 0; j < difficulty; j++) {
                randomSpawnPoints = new Vector3(Random.Range(-1.25f, 1.25f), -1.0f, 1.5f);

                Instantiate(Baloons[j % 3], randomSpawnPoints, Quaternion.identity);
            }

            yield return new WaitForSeconds(5);
        }

        difficulty++;

        StartCoroutine(StartSpawning());
	}
}
