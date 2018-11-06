using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System;

//Struct to hold data for each puzzle. Data includes gate positions and player ball positions
[Serializable]
[System.Xml.Serialization.XmlInclude(typeof(gateData))]
public struct Puzzle
{

    //Player x, y, and z positions
    [XmlAttribute("pX")]
    public float pX;

    [XmlAttribute("pY")]
    public float pY;

    [XmlAttribute("pZ")]
    public float pZ;

    //non-specific gate
    [XmlAttribute("db")]
    public bool db { get; set; }
    [XmlAttribute("dx")]
    public float dx { get; set; }
    [XmlAttribute("dy")]
    public float dy { get; set; }
    [XmlAttribute("dz")]
    public float dz { get; set; }
    [XmlAttribute("drx")]
    public float drx { get; set; }
    [XmlAttribute("dry")]
    public float dry { get; set; }
    [XmlAttribute("drz")]
    public float drz { get; set; }

    //second gate
    [XmlAttribute("sb")]
    public bool sb { get; set; }

    [XmlAttribute("sc")]
    public int sc { get; set; }

    //[XmlAttribute("sx")]
    //public float sx { get; set; }
    //[XmlAttribute("sy")]
    //public float sy { get; set; }
    //[XmlAttribute("sz")]
    //public float sz { get; set; }
    //[XmlAttribute("srx")]
    //public float srx { get; set; }
    //[XmlAttribute("sry")]
    //public float sry { get; set; }
    //[XmlAttribute("srz")]
    //public float srz { get; set; }

    //minute gate

    [XmlAttribute("mb")]
    public bool mb { get; set; }

    [XmlAttribute("mc")]
    public int mc { get; set; }
    //[XmlAttribute("mx")]
    //public float mx { get; set; }
    //[XmlAttribute("my")]
    //public float my { get; set; }
    //[XmlAttribute("mz")]
    //public float mz { get; set; }
    //[XmlAttribute("mrx")]
    //public float mrx { get; set; }
    //[XmlAttribute("mry")]
    //public float mry { get; set; }
    //[XmlAttribute("mrz")]
    //public float mrz { get; set; }

    //hour gate
    [XmlAttribute("hb")]
    public bool hb { get; set; }

    [XmlAttribute("hc")]
    public int hc { get; set; }
    //[XmlAttribute("hx")]
    //public float hx { get; set; }
    //[XmlAttribute("hy")]
    //public float hy { get; set; }
    //[XmlAttribute("hz")]
    //public float hz { get; set; }
    //[XmlAttribute("hrx")]
    //public float hrx { get; set; }
    //[XmlAttribute("hry")]
    //public float hry { get; set; }
    //[XmlAttribute("hrz")]
    //public float hrz { get; set; }

    public Puzzle(float x1, float y1, float z1, gateData gates)
    {
        pX = x1;
        pY = y1;
        pZ = z1;

        db = gates.db;
        dx = gates.dx;
        dy = gates.dy;
        dz = gates.dz;
        drx = gates.drx;
        dry = gates.dry;
        drz = gates.drz;



        sb = gates.sb;
        sc = gates.sc;
        //sx = gates.sx;
        //sy = gates.sy;
        //sz = gates.sz;
        //srx = gates.srx;
        //sry = gates.sry;
        //srz = gates.srz;

        mb = gates.mb;
        mc = gates.mc;
        //mx = gates.mx;
        //my = gates.my;
        //mz = gates.mz;
        //mrx = gates.mrx;
        //mry = gates.mry;
        //mrz = gates.mrz;

        hb = gates.hb;
        hc = gates.hc;
        //hx = gates.hx;
        //hy = gates.hy;
        //hz = gates.hz;
        //hrx = gates.hrx;
        //hry = gates.hry;
        //hrz = gates.hrz;

    }


}

//struct to hold data for gates for each puzzle in a serializable class
[Serializable]
public struct gateData
{
    //positions, boolean for existences, and rotations for each gate

    //non-specific gate
    [XmlAttribute("db")]
    public bool db { get; set; }
    [XmlAttribute("dx")]
    public float dx { get; set; }
    [XmlAttribute("dy")]
    public float dy{ get; set; }
    [XmlAttribute("dz")]
    public float dz{ get; set; }
    [XmlAttribute("drx")]
    public float drx{ get; set; }
    [XmlAttribute("dry")]
    public float dry{ get; set; }
    [XmlAttribute("drz")]
    public float drz{ get; set; }

    //second gate
    [XmlAttribute("sb")]
    public bool sb { get; set; }

    [XmlAttribute("sc")]
    public int sc { get; set; }
    //[XmlAttribute("sx")]
    //public float sx{ get; set; }
    //[XmlAttribute("sy")]
    //public float sy{ get; set; }
    //[XmlAttribute("sz")]
    //public float sz{ get; set; }
    //[XmlAttribute("srx")]
    //public float srx{ get; set; }
    //[XmlAttribute("sry")]
    //public float sry{ get; set; }
    //[XmlAttribute("srz")]
    //public float srz{ get; set; }

    //minute gate

    [XmlAttribute("mb")]
    public bool mb { get; set; }
    [XmlAttribute("mc")]
    public int mc { get; set; }
    //[XmlAttribute("mx")]
    //public float mx{ get; set; }
    //[XmlAttribute("my")]
    //public float my{ get; set; }
    //[XmlAttribute("mz")]
    //public float mz{ get; set; }
    //[XmlAttribute("mrx")]
    //public float mrx{ get; set; }
    //[XmlAttribute("mry")]
    //public float mry{ get; set; }
    //[XmlAttribute("mrz")]
    //public float mrz{ get; set; }

    //hour gate
    [XmlAttribute("hb")]
    public bool hb{ get; set; }

    [XmlAttribute("hc")]
    public int hc { get; set; }

    //[XmlAttribute("hx")]
    //public float hx{ get; set; }
    //[XmlAttribute("hy")]
    //public float hy{ get; set; }
    //[XmlAttribute("hz")]
    //public float hz{ get; set; }
    //[XmlAttribute("hrx")]
    //public float hrx{ get; set; }
    //[XmlAttribute("hry")]
    //public float hry{ get; set; }
    //[XmlAttribute("hrz")]
    //public float hrz{ get; set; }
}
