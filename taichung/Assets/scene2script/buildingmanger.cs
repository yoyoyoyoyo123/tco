using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingmanger : MonoBehaviour
{
    public List<GameObject> buildingLeft = new List<GameObject>();
    public List<GameObject> buildingRight = new List<GameObject>();
    
    public GameObject[] player;
    public int Rnumber;
    public int Lnumber;
    public GameObject gest;

    public bool Llock;
    public bool Rlock;

    public int Rcount;
    public int Lcount;
    public bool Ronetime;
    public bool Lonetime;

    public bool notVRtest;

    public GameObject city;

    //public GameObject fishmanager;
    public float colddowntime;
    public float limittime;
    public GameObject crabmanger;


    public int handcount;
    public bool Lcountone;
    public int citytriggercount;
    public bool Rcountone;
    // Start is called before the first frame update
    void Start()
    {
        Llock = true;
        buildingLeft[0].SetActive(true);
        buildingRight[0].SetActive(true);
        buildingLeft[1].SetActive(true);
        buildingRight[1].SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
        if (notVRtest)
        {
            Lnumber = gest.GetComponent<LGestureDetector>().gesturesnumber;
            Rnumber = gest.GetComponent<GestureDetector>().gesturesnumber;
        }
        else
        {
           // Lnumber = player[1].GetComponent<valuerecueve>().intLvalue;
            //Rnumber = player[1].GetComponent<valuerecueve>().intvalue;
        }


        if (buildingRight.Count == 0)
        {
            Rlock = true;
        }
        if (buildingLeft.Count == 0)
        {
            Llock = true;
        }


        if (Rlock == false)
        {
            
            if (Rnumber == 3)
            {
                
                if(Ronetime == false)
                {
                    buildingRight[0].GetComponent<growvalue>().grow = true;
                    
                    buildingRight.RemoveAt(0);
                    Ronetime = true;
                }
               
            }
            else if(Rnumber == 4)
            {
                Ronetime = false;
            }
            
        }
        else
        {

            Rlock = false;

            if (buildingLeft.Count > 0)
            {
                buildingLeft[0].GetComponent<growvalue>().grow = false;
            }
        }

        if (Llock == false)
        {
            
            if (Lnumber == 3)
            {
                
                if (Lonetime == false)
                {
                    buildingLeft[0].GetComponent<growvalue>().grow = true;
                    
                    buildingLeft.RemoveAt(0);
                    Lonetime = true;
                }
            }
            else if(Lnumber == 4)
            {
                Lonetime = false;
            }
            
        }
        else
        {
                
            Llock = false;
            if (buildingRight.Count > 0)
            {
                buildingRight[0].GetComponent<growvalue>().grow = false;
            }
            
        }
        
        if(buildingRight.Count == 0 && buildingLeft.Count == 0)
        {
            if (colddowntime >= limittime)
            {

                city.SetActive(true);
                if (Rnumber == 3)
                {
                    if (Rcountone)
                    {
                        handcount += 1;
                        Rcountone = false;
                    }                   
                }
                if (Lnumber == 3)
                {
                    if (Lcountone)
                    {
                        handcount += 1;
                        Lcountone = false;
                    }
                }
                if (Lnumber == 4)
                {
                    Lcountone = true;
                }
                if (Rnumber == 4)
                {
                    Rcountone = true;
                }

                colddowntime = limittime;
            }
            if(handcount >= citytriggercount)
            {
                city.GetComponent<citybuild>().up = true;
            }
            
            colddowntime += Time.deltaTime;
        }

        
    }
}
