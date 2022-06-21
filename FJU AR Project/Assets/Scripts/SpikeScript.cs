using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
	public GameObject smoke;
	public LifeRemainScript lifeRemainScript;

	private void OnTriggerEnter (Collider other) {

		lifeRemainScript.lifeRemain--;

		Destroy(other.transform.gameObject);

		Instantiate(smoke, other.transform.position, Quaternion.LookRotation(Vector3.up));
	}
}
