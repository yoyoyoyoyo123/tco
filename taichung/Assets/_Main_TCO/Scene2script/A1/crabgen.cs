using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crabgen : MonoBehaviour
{
    public GameObject gesture;
    public GameObject[] players;
    private float holdruntime;
    public float holdtime;
    private float colddownruntime;
    public float colddowntime;
    public bool trigger;
    public bool onetimetrigger;
    // Start is called before the first frame update
    void Start()
    {
        //gesture = GameObject.Find("Gesture Detection");

    }

    // Update is called once per frame
    void Update()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        if(colddownruntime >= colddowntime)
        {
            colddownruntime = colddowntime;
            if (trigger)
            {
                if (holdruntime >= holdtime)
                {
                    if (onetimetrigger == false)
                    {
                        players[1].GetComponent<valuerecueve>().boolvalue = true;
                        onetimetrigger = true;
                    }
                    holdruntime = holdtime;
                }
                holdruntime += Time.deltaTime;
            }
        }
        colddownruntime += Time.deltaTime;

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "thumb" && gesture.GetComponent<GestureDetector>().gesturesnumber == 2 && gesture.GetComponent<LGestureDetector>().gesturesnumber == 2)
        {
            
            if (players.Length > 1)
            {
                trigger = true;
            }
            
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "thumb")
        {
            colddownruntime = 0;
            if (players.Length > 1)
            {
                holdruntime = 0;
                players[1].GetComponent<valuerecueve>().boolvalue = false;
                onetimetrigger = false;
                trigger = false;
            }
        }
    }
    
}
