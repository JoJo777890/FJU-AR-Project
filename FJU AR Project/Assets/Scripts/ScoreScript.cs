using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public float score = 0;

    public Text scoreText;

    void Update()
    {
        scoreText.text = score.ToString();
    }
}
