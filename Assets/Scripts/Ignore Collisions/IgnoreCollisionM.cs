using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollisionM : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Physics.IgnoreCollision(GameObject.FindGameObjectWithTag("Second Hand").GetComponent<BoxCollider>(), this.GetComponent<BoxCollider>());
        Physics.IgnoreCollision(GameObject.FindGameObjectWithTag("Hour Hand").GetComponent<BoxCollider>(), this.GetComponent<BoxCollider>());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
