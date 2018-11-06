using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float startingX;
    Rigidbody playerRigidbody;

    private void Start()
    {
        playerRigidbody = this.gameObject.GetComponent<Rigidbody>();
        playerRigidbody.useGravity = false;
        startingX = this.transform.position.x;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            playerRigidbody.useGravity = true;
        }

    }

    public void setGrav(bool i)
    {
        playerRigidbody.useGravity = i;
    }
}