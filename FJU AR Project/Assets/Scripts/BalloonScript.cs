using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonScript : MonoBehaviour
{
    public float speed;
	public float topSpeed;
	public float maxSpeed = 1.0f;

	public SpawnScript spawnScript;

	void Start () {

		spawnScript = FindObjectOfType<SpawnScript>();

		topSpeed = (float)spawnScript.difficulty * 0.1f;
		speed = Random.Range(0.1f, topSpeed);

		Debug.Log("Difficulty: " + spawnScript.difficulty + 
				"\nTopSpeed: " + topSpeed);
	}

	void Update()
    {
        this.transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
