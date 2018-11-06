using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondHand : MonoBehaviour
{

    public GameManager gm;

    // Use this for initialization
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.name == "TopRight" || other.transform.gameObject.name == "TopLeft" || other.transform.gameObject.name == "BottomLeft" || other.transform.gameObject.name == "BottomRight")
        {
            if (other.transform.gameObject.GetComponent<BlockScript>().Status == 1)
            {
                Debug.Log("Second hand should be set as true");
                gm.secondGateMet = true;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.gameObject.name == "TopRight" || other.transform.gameObject.name == "TopLeft" || other.transform.gameObject.name == "BottomLeft" || other.transform.gameObject.name == "BottomRight")
        {
            if (other.transform.gameObject.GetComponent<BlockScript>().Status == 1)
            {
                Debug.Log("Second hand should be set as true");
                gm.secondGateMet = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.gameObject.name == "TopRight" || other.transform.gameObject.name == "TopLeft" || other.transform.gameObject.name == "BottomLeft" || other.transform.gameObject.name == "BottomRight")
        {
            if (other.transform.gameObject.GetComponent<BlockScript>().Status == 1)
            {
                Debug.Log("Second hand should be set as false");
                gm.secondGateMet = false;
            }
        }
    }
}
