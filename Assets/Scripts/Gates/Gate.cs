using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : BaseGate {

    GameManager gm;


	// Use this for initialization
	void Start () {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        type = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hit the gate with the player");
            if(gm.gateCheck())
                gm.nextPuzzle();
        }
    }
}
