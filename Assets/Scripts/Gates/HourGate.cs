using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourGate : BaseGate
{

    GameManager gm;
    private bool gatePass;

    // Use this for initialization
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        gatePass = false;
        type = 1;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }

    /// <summary>
    /// checks whether this hand of the clock is in contact with a time gate
    /// </summary>
    /// <returns></returns>
    public bool getGatePass()
    {
        Debug.Log(gatePass);
        return gatePass;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ONTRIGGERSTAY");
        if (collision.gameObject.name == "HourCube")
        {
            gatePass = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("ONTRIGGERSTAY");
        if (other.gameObject.name == "HourCube")
        {
            gatePass = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("ONTRIGGERSTAY");
        if (collision.gameObject.name == "HourCube")
        {
            gatePass = false;
        }
    }
}
