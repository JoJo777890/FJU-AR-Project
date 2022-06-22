using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreScript : MonoBehaviour
{
    public Text finalScore;

	private void Start () {

		finalScore.text = "Your Score: " + ScoreScript.score.ToString();
	}
}
