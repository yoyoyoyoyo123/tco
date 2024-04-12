using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handposition : MonoBehaviour
{
    public GameObject[] player;
    public bool right;
    public bool left;
    public bool head;
    public float x;
    public float y;
    public float z;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        player = GameObject.FindGameObjectsWithTag("Player");

        x = this.gameObject.transform.rotation.eulerAngles.x;
        y = this.gameObject.transform.rotation.eulerAngles.y;
        z = this.gameObject.transform.rotation.eulerAngles.z;
        if (right)
        {
            
            if (player.Length > 1)
            {
                player[1].GetComponent<valuerecueve>().handRxvalue = this.gameObject.transform.position.x;
                player[1].GetComponent<valuerecueve>().handRyvalue = this.gameObject.transform.position.y;
                player[1].GetComponent<valuerecueve>().handRzvalue = this.gameObject.transform.position.z;
                player[1].GetComponent<valuerecueve>().handRroxvalue = this.gameObject.transform.rotation.eulerAngles.x;
                player[1].GetComponent<valuerecueve>().handRroyvalue = this.gameObject.transform.rotation.eulerAngles.y;
                player[1].GetComponent<valuerecueve>().handRrozvalue = this.gameObject.transform.rotation.eulerAngles.z;


            }
        }
        if (left)
        {
           
            if (player.Length > 1)
            {
                player[1].GetComponent<valuerecueve>().handLxvalue = this.gameObject.transform.position.x;
                player[1].GetComponent<valuerecueve>().handLyvalue = this.gameObject.transform.position.y;
                player[1].GetComponent<valuerecueve>().handLzvalue = this.gameObject.transform.position.z;
                player[1].GetComponent<valuerecueve>().handLroxvalue = this.gameObject.transform.rotation.eulerAngles.x;
                player[1].GetComponent<valuerecueve>().handLroyvalue = this.gameObject.transform.rotation.eulerAngles.y;
                player[1].GetComponent<valuerecueve>().handLrozvalue = this.gameObject.transform.rotation.eulerAngles.z;

            }
        }
        if (head)
        {
            if (player.Length > 1)
            {
                player[1].GetComponent<valuerecueve>().headxvalue = this.gameObject.transform.position.x;
                player[1].GetComponent<valuerecueve>().headyvalue = this.gameObject.transform.position.y;
                player[1].GetComponent<valuerecueve>().headzvalue = this.gameObject.transform.position.z;

            }
        }



    }
}
