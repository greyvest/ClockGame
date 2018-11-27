using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSwitch : MonoBehaviour {

    public Canvas menuCan;
    public GameManager gm;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void menuSwitch()
    {
        if (menuCan.gameObject.activeSelf)
        {
            Debug.Log("Deactivate menu");
            menuCan.gameObject.SetActive(false);
            gm.resetLevel();

        }
        else
        {
            menuCan.gameObject.SetActive(true);
        }
    }
}
