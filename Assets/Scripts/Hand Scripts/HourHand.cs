using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourHand : MonoBehaviour
{

    public GameManager gm;
    public bool debug;
    public LayerMask lm;

    // Use this for initialization
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

       
        Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, Quaternion.identity, lm);
        int i = 0;
        //Check when there is a new collider coming into contact with the box
        while (i < hitColliders.Length)
        {
            //Output all of the collider names
            //Increase the number of Colliders in the array
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.name == "TopRight" || other.transform.gameObject.name == "TopLeft" || other.transform.gameObject.name == "BottomLeft" || other.transform.gameObject.name == "BottomRight")
        {
            if (other.transform.gameObject.GetComponent<BlockScript>().Status == 3)
            {
                if (debug)
                    Debug.Log("Hour hand should be set as true");
                gm.hourGateMet = true;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.gameObject.name == "TopRight" || other.transform.gameObject.name == "TopLeft" || other.transform.gameObject.name == "BottomLeft" || other.transform.gameObject.name == "BottomRight")
        {
            if (other.transform.gameObject.GetComponent<BlockScript>().Status == 3)
            {
                if (debug)
                    Debug.Log("Hour hand should be set as true");
                gm.hourGateMet = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.gameObject.name == "TopRight" || other.transform.gameObject.name == "TopLeft" || other.transform.gameObject.name == "BottomLeft" || other.transform.gameObject.name == "BottomRight")
        {
            if (other.transform.gameObject.GetComponent<BlockScript>().Status == 3)
            {
                if (debug)
                    Debug.Log("Hour hand should be set as false");
                gm.hourGateMet = false;
            }
        }
    }
}
