using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
	public void RestartGame () {

		SceneManager.LoadScene("SampleScene");
	}

	public void Credit () {
		SceneManager.LoadScene("Credit");
	}
}
