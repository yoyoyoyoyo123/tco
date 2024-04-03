using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class midtri : MonoBehaviour
{
    public GameObject gesture;
    public GameObject[] players;
    
    public bool allowtrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

    }
    void OnTriggerEnter(Collider other)
    {
        if (allowtrigger)
        {
            if (other.tag == "midfinger" && gesture.GetComponent<GestureDetector>().gesturesnumber == 1 && gesture.GetComponent<LGestureDetector>().gesturesnumber == 1)
            {
                if (players.Length > 1)
                {

                    players[1].GetComponent<valuerecueve>().housevalue = true;

                }

            }
        }
        

    }
}
