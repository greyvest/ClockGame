using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{

    public bool clockActive = true;

    [SerializeField]
    GameObject secondHand;

    [SerializeField]
    GameObject minuteHand;

    [SerializeField]
    GameObject hourHand;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (clockActive)
        {
            DateTime currentTime = DateTime.Now;

            float secondsDegree = -(currentTime.Second / 60f) * 360f;
            secondHand.transform.localRotation = Quaternion.Lerp(secondHand.transform.localRotation, Quaternion.Euler(new Vector3(0, 0, secondsDegree)), 1);

            float minutesDegree = -(currentTime.Minute / 60f) * 360f;
            minuteHand.transform.localRotation = Quaternion.Lerp(minuteHand.transform.localRotation, Quaternion.Euler(new Vector3(0, 0, minutesDegree)), 1);

            float hoursDegree = -(currentTime.Hour / 12f) * 360f;
            hourHand.transform.localRotation = Quaternion.Lerp(hourHand.transform.localRotation, Quaternion.Euler(new Vector3(0, 0, hoursDegree)), 1);

        }
    }
}
