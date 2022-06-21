using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    }
}
