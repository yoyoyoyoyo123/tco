using Unity.Netcode;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class valuerecueve : NetworkBehaviour
{
    [SerializeField]
    private NetworkVariable<bool> seeornot = new NetworkVariable<bool>();
    [SerializeField]
    private NetworkVariable<bool> housetri = new NetworkVariable<bool>();
    [SerializeField]
    private NetworkVariable<int> handRvalue = new NetworkVariable<int>();
    [SerializeField]
    private NetworkVariable<int> handLvalue = new NetworkVariable<int>();
    [SerializeField]
    private NetworkVariable<float> handx = new NetworkVariable<float>();
    [SerializeField]
    private NetworkVariable<float> handy = new NetworkVariable<float>();
    [SerializeField]
    private NetworkVariable<float> handz = new NetworkVariable<float>();


    //public GameObject[] center;
    public List<GameObject> center = new List<GameObject>();
    //public GameObject center;
    public GameObject[] centerarray;
    public bool onetime;
    public bool onetime2;


    public bool boolvalue;
    public bool housevalue;
    public int intvalue;
    public int intLvalue;
    public int ranvalue;
    public float handxvalue;
    public float handyvalue;
    public float handzvalue;

    public bool netbool;
    public bool nethousebool;
    public float nethandx;
    public float nethandy;
    public float nethandz;
    public int netint;
    public int netLint;


    public bool oldinput;
    public bool oldhouseinput;
    public int oldintinput;
    public int oldintLinput;
    public float oldhandx;
    public float oldhandy;
    public float oldhandz;


    public GameObject building;
    public GameObject hand;
    public GameObject crab;
    public List<GameObject> crabs = new List<GameObject>();
    public int crabsamount;
    public bool onetimetrigger;
    public GameObject crabman;


    public float runtime;
    public float litime;

    public bool countone;
    public GameObject[] mid;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {

        //center = GameObject.Find("center");
        cam = GameObject.FindGameObjectWithTag("fishmanager");
        crabman = GameObject.FindGameObjectWithTag("crabman");
        building = GameObject.FindGameObjectWithTag("build");
        mid = GameObject.FindGameObjectsWithTag("midfinger");
    }

    // Update is called once per frame
    void Update()
    {
        
        hand = GameObject.FindGameObjectWithTag("hand");
        

        if (IsServer)
        {
            UpdateServer();
        }
        if (IsClient && IsOwner)
        {
            ClientInput();
        }

        if(hand.GetComponent<handposition>().player.Length > 1)
        {
            if (this.gameObject == hand.GetComponent<handposition>().player[1])
            {
                hand.transform.position = new Vector3(handx.Value, handy.Value, handz.Value);
            }
        }

        this.transform.position = new Vector3(handx.Value, handy.Value, handz.Value);

        
        if (crabsamount >= 4)
        {
            crabsamount = 4;
            foreach(GameObject mi in mid)
            {
                if(mi.name == "midL ")
                {
                    mi.gameObject.GetComponent<midtri>().allowtrigger = true;
                }
            }
            if (housetri.Value || Input.GetKeyDown(KeyCode.Alpha2))
            {
                for (int i = 0; i < 4; i++)
                {

                    crabman.GetComponent<crabmove>().crabs[i].GetComponent<crabwalk>().walk = false;
                }
                crabman.GetComponent<crabmove>().move = true;
                
                


            }
          
        }
        else
        {

            if (seeornot.Value || Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (!onetimetrigger)
                {
                    GameObject cra = Instantiate(crab, new Vector3(handx.Value, handy.Value, handz.Value), Quaternion.Euler(new Vector3(90, 0, 0)));
                    crabs.Add(cra);
                    countone = true;
                }
                onetimetrigger = true;

                crabs[0].transform.position = Vector3.Lerp(crabs[0].transform.position, new Vector3(handx.Value, handy.Value, handz.Value), 0.1f);
                
            }
            else
            {
                if(crabs.Count >= 1)
                {
                    crabs[0].GetComponent<crabwalk>().walk = true;
                }
                
                onetimetrigger = false;
                if (crabs.Count > 0)
                {
                    crabs.RemoveAt(0);
                }
                if (countone)
                {
                    crabsamount += 1;
                    countone = false;
                }
            }
        }


        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            cam.GetComponent<fishman>().grown = true;
        }
        

        if (building.GetComponent<buildingmanger>().enabled)
        {
            building.GetComponent<buildingmanger>().Rnumber = handRvalue.Value;
            building.GetComponent<buildingmanger>().Lnumber = handLvalue.Value;
        }

        if (cam.GetComponent<fishmanager>().enabled)
        {
            if(handRvalue.Value == 5)
            {
                cam.GetComponent<fishmanager>().trigger = true;
            }
            
        }
    }
    private void UpdateServer()
    {
        netbool = seeornot.Value;
        nethousebool = housetri.Value;
        netint = handRvalue.Value;
        nethandx = handx.Value;
        nethandy = handy.Value;
        nethandz = handz.Value;
        
    }

    public void ClientInput()
    {
        if (oldinput != boolvalue || oldhouseinput != housevalue || oldintinput != intvalue || oldintLinput != intLvalue || oldhandx != handxvalue || oldhandy != handyvalue || oldhandz != handzvalue)
        {
            oldinput = boolvalue;
            oldhouseinput = housevalue;
            oldintinput = intvalue;
            oldintLinput = intLvalue;
            oldhandx = handxvalue;
            oldhandy = handyvalue;
            oldhandz = handzvalue;
            UpdateClientPositionAndRotationServerRpc(boolvalue , housevalue, intvalue , intLvalue, handxvalue, handyvalue, handzvalue);

        }
    }
    [ServerRpc]
    public void UpdateClientPositionAndRotationServerRpc(bool value,bool houseval ,int invalue,int intLvalue, float hx,float hy,float hz)
    {
        seeornot.Value = value;
        housetri.Value = houseval;
        handRvalue.Value = invalue;
        handLvalue.Value = intLvalue;
        handx.Value = hx;
        handy.Value = hy;
        handz.Value = hz;

    }

}
