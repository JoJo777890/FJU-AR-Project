using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeRemainScript : MonoBehaviour
{
    public int lifeRemain = 3;

    public Text lifeRemainText;

	private void Start () {
        lifeRemain = 3;
	}

	void Update()
    {
        lifeRemainText.text = "Life Remain: " + lifeRemain.ToString();

        if(lifeRemain == 0) {
            SceneManager.LoadScene("GameOver");
		}
    }
}
