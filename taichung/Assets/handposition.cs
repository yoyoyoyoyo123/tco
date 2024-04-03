using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handposition : MonoBehaviour
{
    public GameObject[] player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectsWithTag("Player");



        if (player.Length > 1)
        {
            player[1].GetComponent<valuerecueve>().handxvalue = this.gameObject.transform.position.x;
            player[1].GetComponent<valuerecueve>().handyvalue = this.gameObject.transform.position.y;
            player[1].GetComponent<valuerecueve>().handzvalue = this.gameObject.transform.position.z;

        }



    }
}
