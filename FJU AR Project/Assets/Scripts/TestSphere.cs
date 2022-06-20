using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSphere : MonoBehaviour
{
	void Update () {

        this.transform.Translate(Vector3.down * Time.deltaTime * 0.02f);
    }
}
