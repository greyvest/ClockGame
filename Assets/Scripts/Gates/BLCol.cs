using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BLCol : MonoBehaviour {
    public GameManager gm;
    public int Status;

    // Use this for initialization
    void Start()
    {
        Status = 0;
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        switch (Status)
        {
            case 0:
                //Nothing
                break;
            case 1:
                //Second Gate
                if (other.tag == "Second Hand")
                {
                    gm.secondGateMet = true;
                }
                break;
            case 2:
                //Minute Gate
                if (other.tag == "Minute Hand")
                {
                    gm.minuteGateMet = true;
                }
                break;
            case 3:
                //Hour Gate
                if (other.tag == "Hour Hand")
                {
                    gm.hourGateMet = true;
                }
                break;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (Status)
        {
            case 0:
                //Nothing
                break;
            case 1:
                //Second Gate
                if (other.tag == "Second Hand")
                {
                    gm.secondGateMet = false;
                }
                break;
            case 2:
                //Minute Gate
                if (other.tag == "Minute Hand")
                {
                    gm.minuteGateMet = false;
                }
                break;
            case 3:
                //Hour Gate
                if (other.tag == "Hour Hand")
                {
                    gm.hourGateMet = false;
                }
                break;

        }
    }
}
