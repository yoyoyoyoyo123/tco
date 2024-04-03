using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishmanager : MonoBehaviour
{
    public GameObject cameram;
       
    

    public float colddowntime;
    public float runtime;
    public bool trigger;
    
    // Start is called before the first frame update
    void Start()
    {
        cameram.GetComponent<Animator>().SetBool("move", true);
    }

    // Update is called once per frame
    void Update()
    {
        if(runtime >= colddowntime)
        {
            if (Input.GetKeyDown(KeyCode.Alpha4) || trigger)
            {

                this.GetComponent<Animator>().SetBool("move2", true);
            }
            
        }
        runtime = colddowntime;

    }
}
