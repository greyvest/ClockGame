using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondGate : BaseGate
{

    GameManager gm;
    private bool gatePass;


    // Use this for initialization
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        type = 3;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public bool getGatePass()
    {
        return gatePass;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "SecondCube")
        {
            gatePass = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "SecondCube")
        {
            gatePass = false;
        }
    }
}
