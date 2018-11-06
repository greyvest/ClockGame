using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreHandsSecond : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Physics.IgnoreCollision(GameObject.FindGameObjectWithTag("Second Cube").GetComponent<BoxCollider>(), this.GetComponent<BoxCollider>());
        Physics.IgnoreCollision(GameObject.FindGameObjectWithTag("Minute Cube").GetComponent<BoxCollider>(), this.GetComponent<BoxCollider>());

    }

    // Update is called once per frame
    void Update () {
		
	}
}
