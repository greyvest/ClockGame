using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System;

public class BaseGate : MonoBehaviour {

    public static List<BaseGate> allGates;


    /*
     * In order to be able to serialize while still keeping track of the type of gate, I'm going to have an id number that each gate type must overide. 
     * Vanilla gate = 0
     * Hour Gate = 1
     * Minute Gate = 2
     * Second Gate = 3
     * */
    public int type;
	// Use this for initialization
	public BaseGate()
    {
       // allGates.Add(this);
	}
	
	// Update is called once per frame
	public void Update () {
		
	}

    static void createXML()
    {
        //XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<BaseGate>));
        //FileStream fileStream = new FileStream(Application.persistentDataPath + "gatedata.xml", FileMode.Create);
        //xmlSerializer.Serialize(fileStream, allGates);
        //fileStream.Close();
    }


}
