using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject gatePrefab;
    /*public GameObject secondGatePrefab;
    public GameObject minuteGatePrefab;
    public GameObject hourGatePrefab;*/
    public float clockSpeed = -0.1f;

    public Material p;
    public Material g;
    public Material r;
    public Material d;

    private WordScript script;

    public UnityEngine.UI.Text cText; 

    //This bool will determine whether I want the actual time or a specified test time
    public bool testTime;

    public int testHour;
    public int testMin;

    public bool hourGateMet;
    public bool minuteGateMet;
    public bool secondGateMet;

    public float timer;

    //int to track what puzzle the player should currently be working on
    private int puzzleID;
    //Player Class
    PlayerController player;

    GameObject secondHand;
    GameObject minuteHand;
    GameObject hourHand;

    //List of puzzle data
    [XmlArray("Puzzles")]
    [XmlArrayItem("Puzle")]
    List<Puzzle> puzzleList;
    private float timeToWait;
    private int timerStatus;
    public TextAsset puzzledatafile;

    // Use this for initialization
    void Start()
    {
        script = new WordScript();
        script.setLines();
        timerStatus = 0;
        resetBools();

        //Debug.Log(Application.persistentDataPath);
        //get player object
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        //instatiate puzzle list
        puzzleList = new List<Puzzle>();
        //load all the puzzles into the list
        puzzleList = loadPuzzles();
        //load the previous progress in so we know which puzzle to spawn on startup.
        puzzleID = loadID();
        timerStatus = loadID();
        //set current puzzle
        setPuzzle(puzzleID);

        secondHand = GameObject.FindGameObjectWithTag("Second Hand");
        minuteHand = GameObject.FindGameObjectWithTag("Minute Hand");
        hourHand = GameObject.FindGameObjectWithTag("Hour Hand");

        secondHand.GetComponent<Rigidbody>().centerOfMass = new Vector3(0, -1.4f, 0);
        minuteHand.GetComponent<Rigidbody>().centerOfMass = new Vector3(0, -1.2f, 0);
        hourHand.GetComponent<Rigidbody>().centerOfMass = new Vector3(0, -.75f, 0);

        DateTime currentTime = DateTime.Now;

        float secondsDegree = -(currentTime.Second / 60f) * 360f;
        secondHand.GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(new Vector3(0, 0, secondsDegree)));

        if (testTime) {
            float minutesDegree = -(testMin / 60f) * 360f;
            minuteHand.GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(new Vector3(0, 0, minutesDegree)));

            float hoursDegree = -( testHour / 12f) * 360f;
            hourHand.GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(new Vector3(0, 0, hoursDegree)));


        }
        else
        {
            float minutesDegree = -(currentTime.Minute / 60f) * 360f;
            minuteHand.GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(new Vector3(0, 0, minutesDegree)));

            float hoursDegree = -(currentTime.Hour / 12f) * 360f;
            hourHand.GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(new Vector3(0, 0, hoursDegree)));
        }


        secondHand.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, clockSpeed);
        minuteHand.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, clockSpeed / 60);
        hourHand.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, clockSpeed / (60 * 60 * 12));

        timer = 0f;
        cText.text = script.Lines[timerStatus];
        Debug.Log(script.Lines[timerStatus]);
  
    }

    private void resetBools()
    {
        hourGateMet = false;
        minuteGateMet = false;
        secondGateMet = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        secondHand.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, clockSpeed);
        minuteHand.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, clockSpeed / 60);
        hourHand.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, clockSpeed / (60 * 60 * 12));

        if (Input.GetKeyDown(KeyCode.P))
        {
            nextPuzzle();
        }

    }

    private IEnumerator updateTimer()
    {
        timerStatus += 1;
        cText.GetComponent<FadeScript>().FadeOut();
        yield return new WaitForSeconds(2);
        cText.text = script.Lines[timerStatus];
        cText.GetComponent<FadeScript>().FadeIn();
    }

    //MISC 

    //Class to create a gateData object from the currently placed gates in the scene
    private gateData createGateData()
    {
        gateData retData = new gateData();

        Gate dGate = GameObject.Find("Gate").GetComponent<Gate>();
        retData.db = dGate;
        retData.dx = dGate.transform.position.x;
        retData.dy = dGate.transform.position.x;
        retData.dz = dGate.transform.position.x;
        retData.drx = dGate.transform.position.x;
        retData.dry = dGate.transform.position.x;
        retData.drz = dGate.transform.position.x;

        //if (GameObject.Find("SecondGate") != null)
        //{
        //    SecondGate sGate = GameObject.Find("SecondGate").GetComponent<SecondGate>();
        //    retData.db = sGate;
        //    retData.sx = sGate.transform.position.x;
        //    retData.sy = sGate.transform.position.x;
        //    retData.sz = sGate.transform.position.x;
        //    retData.srx = sGate.transform.position.x;
        //    retData.sry = sGate.transform.position.x;
        //    retData.srz = sGate.transform.position.x;

        //}

        //if (GameObject.Find("MinuteGate") != null)
        //{
        //    MinuteGate mGate = GameObject.Find("MinuteGate").GetComponent<MinuteGate>();
        //    retData.db = mGate;

        //    retData.mx = mGate.transform.position.x;
        //    retData.my = mGate.transform.position.x;
        //    retData.mz = mGate.transform.position.x;
        //    retData.mrx = mGate.transform.position.x;
        //    retData.mry = mGate.transform.position.x;
        //    retData.mrz = mGate.transform.position.x;

        //}

        //if (GameObject.Find("HourGate") != null)
        //{
        //    HourGate hGate = GameObject.Find("HourGate").GetComponent<HourGate>();
        //    retData.hb = hGate;

        //    retData.hx = hGate.transform.position.x;
        //    retData.hy = hGate.transform.position.x;
        //    retData.hz = hGate.transform.position.x;
        //    retData.hrx = hGate.transform.position.x;
        //    retData.hry = hGate.transform.position.x;
        //    retData.hrz = hGate.transform.position.x;

        //}

        return retData;
    }

    //Use this to reset the ball after a failed attempt
    public void resetLevel()
    {
        player.setGrav(false);
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.gameObject.SetActive(false);
        player.transform.position = new Vector3(puzzleList[puzzleID].pX, puzzleList[puzzleID].pY, puzzleList[puzzleID].pZ);
        player.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        player.gameObject.SetActive(true);
    }

    /// <summary>
    /// Checks each spawned time gate and returns whether all are in contact with a clock hand
    /// </summary>
    /// <returns>Whether gate is in contact with hand of clock</returns>
    public bool gateCheck()
    {
        Debug.Log("Gate Check");
        var g = puzzleList[puzzleID];
        if (g.sb)
        {
            if (!secondGateMet)
            {
                Debug.Log("Second Gate failed");
                return false;

            }
        }   
        if (g.mb)
        {
            if (!minuteGateMet)
            {
                Debug.Log("Minute Gate failed");
                return false;
            }
                
        }
        if (g.hb)
        {
            if (!hourGateMet)
            {
                Debug.Log("Hour Gate failed");
                return false;
            }
                
        }
        Debug.Log("Return true");
        return true;

    }

    //Puzzle functions

    //Take in a puzzle ID int and set the gates/ball positions based on that;
    private void setPuzzle(int puzzleID)
    {
        resetBools();
        resetMaterials();
        //Debug.Log("Setting puzzle " + puzzleID);
        player.gameObject.SetActive(false);
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        var g = puzzleList[puzzleID];
        if (g.db)
        {
            Quaternion newQ = Quaternion.Euler(g.drx, g.dry, g.drz);
            Instantiate(gatePrefab, new Vector3(g.dx, g.dy, g.dz), newQ);
        }
        if (g.sb)
        {
            //Quaternion newQ = Quaternion.Euler(g.srx, g.sry, g.srz);
            //Instantiate(secondGatePrefab, new Vector3(g.sx, g.sy, g.sz), newQ);
            setSecondGate(g.sc);
        }
        if (g.mb)
        {
            //Quaternion newQ = Quaternion.Euler(g.mrx, g.mry, g.mrz);
            //Instantiate(minuteGatePrefab, new Vector3(g.mx, g.my, g.mz), newQ);
            setMinuteGate(g.mc);
        }
        if (g.hb)
        {
            //Quaternion newQ = Quaternion.Euler(g.hrx, g.hry, g.hrz);
            //Instantiate(hourGatePrefab, new Vector3(g.hx, g.hy, g.hz), newQ);
            setHourGate(g.hc);

        }
        player.setGrav(false);
        player.transform.position = new Vector3(puzzleList[puzzleID].pX, puzzleList[puzzleID].pY, puzzleList[puzzleID].pZ);
        player.gameObject.SetActive(true);
        
    }

    private void resetMaterials()
    {
        GameObject.Find("TopLeft").GetComponent<Renderer>().material = d;
        GameObject.Find("TopRight").GetComponent<Renderer>().material = d;
        GameObject.Find("BottomLeft").GetComponent<Renderer>().material = d;
        GameObject.Find("BottomRight").GetComponent<Renderer>().material = d;
    }

    private void setHourGate(int hc)
    {
        switch (hc)
        {
            case 0:
                GameObject.Find("TopLeft").GetComponent<Renderer>().material = g;
                GameObject.Find("TopLeft").GetComponent<BlockScript>().Status = 3;
                break;
            case 1:
                GameObject.Find("TopRight").GetComponent<Renderer>().material = g;
                GameObject.Find("TopRight").GetComponent<BlockScript>().Status = 3;
                break;
            case 2:
                GameObject.Find("BottomRight").GetComponent<Renderer>().material = g;
                GameObject.Find("BottomRight").GetComponent<BlockScript>().Status = 3;
                break;
            case 3:
                GameObject.Find("BottomLeft").GetComponent<Renderer>().material = g;
                GameObject.Find("BottomLeft").GetComponent<BlockScript>().Status = 3;
                break;
        }
    }

    private void setMinuteGate(int mc)
    {
        switch (mc)
        {
            case 0:
                GameObject.Find("TopLeft").GetComponent<Renderer>().material = p;
                GameObject.Find("TopLeft").GetComponent<BlockScript>().Status = 2;
                break;
            case 1:
                GameObject.Find("TopRight").GetComponent<Renderer>().material = p;
                GameObject.Find("TopRight").GetComponent<BlockScript>().Status = 2;
                break;
            case 2:
                GameObject.Find("BottomRight").GetComponent<Renderer>().material = p;
                GameObject.Find("BottomRight").GetComponent<BlockScript>().Status = 2;
                break;
            case 3:
                GameObject.Find("BottomLeft").GetComponent<Renderer>().material = p;
                GameObject.Find("BottomLeft").GetComponent<BlockScript>().Status = 2;
                break;
        }
    }

    private void setSecondGate(int sc)
    {
        Debug.Log("SetSecondGate");
        switch (sc)
        {
            case 0:
                GameObject.Find("TopLeft").GetComponent<Renderer>().material = r;
                GameObject.Find("TopLeft").GetComponent<BlockScript>().Status = 1;
                break;
            case 1:
                GameObject.Find("TopRight").GetComponent<Renderer>().material = r;
                GameObject.Find("TopRight").GetComponent<BlockScript>().Status = 1;
                break;
            case 2:
                GameObject.Find("BottomRight").GetComponent<Renderer>().material = r;
                GameObject.Find("BottomRight").GetComponent<BlockScript>().Status = 1;
                break;
            case 3:
                GameObject.Find("BottomLeft").GetComponent<Renderer>().material = r;
                GameObject.Find("BottomLeft").GetComponent<BlockScript>().Status = 1;
                break;
        }
    }

    //function to reset the ball after success, set up the next puzzle.  
    internal void nextPuzzle()
    {
        //Set all old gates to inactive
        despawnGates();
        //increment to next puzzle
        incPID();
        //set next puzzle
        setPuzzle(puzzleID);
        //save progress after incrementing puzzle id so that the next puzzle will be the one the player starts on if they restart the game.
        saveProgress();

        StartCoroutine(updateTimer());
    }

    //public static void savePuzzles(List<Puzzle> list)
    //{
    //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Puzzle>));
    //    FileStream fileStream = new FileStream(UnityEngine.Application.persistentDataPath + "Puzzles.xml", FileMode.Create);
    //    xmlSerializer.Serialize(fileStream, list);
    //    fileStream.Close();
    //}

    public List<Puzzle> loadPuzzles()
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Puzzle>));

        using (var reader = new System.IO.StringReader(puzzledatafile.text))
        {
            return xmlSerializer.Deserialize(reader) as List<Puzzle>;
        }
        
    }

    //save the player's progress by incrementing the puzzle id;
    private void saveProgress()
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(int));
        FileStream fileStream = new FileStream(Application.persistentDataPath + "savedata.xml", FileMode.Create);
       
        xmlSerializer.Serialize(fileStream, puzzleID);
        fileStream.Close();
    }

    public void resetProgress()
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(int));
        FileStream fileStream = new FileStream(Application.persistentDataPath + "savedata.xml", FileMode.Create);

        xmlSerializer.Serialize(fileStream, 0);
        fileStream.Close();
        despawnGates();
        Start();
    }

    private static void despawnGates()
    {
        foreach (GameObject x in GameObject.FindGameObjectsWithTag("Gate"))
        {
            x.SetActive(false);
        }
    }

    //Level ID Functions//

    //Load the current level
    private int loadID()
    {

        if (File.Exists(Application.persistentDataPath + "savedata.xml"))
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(int));
            FileStream fileStream = new FileStream(Application.persistentDataPath + "savedata.xml", FileMode.Open);
            int retint = (int)xmlSerializer.Deserialize(fileStream);
            fileStream.Close();
            Debug.Log(retint);
            return retint;
        }
        else
            return 0;
    }

    //Get the current level
    public int getPID()
    {
        return puzzleID;
    }

    //increment puzzle id so you can load the next level
    public void incPID()
    {
        puzzleID++;
    }

}
