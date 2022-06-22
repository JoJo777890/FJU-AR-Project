using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static float score = 0;

    public Text scoreText;

	private void Start () {
        score = 0;
	}

	void Update()
    {
        scoreText.text = score.ToString();
    }
}
