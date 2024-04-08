using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishmanager : MonoBehaviour
{
    public GameObject cameram;

    public fishman fishman;

    public float colddowntime;
    public float runtime;
    public bool trigger;
    public bool fishtrigger;
    // Start is called before the first frame update
    void Start()
    {
        cameram.GetComponent<Animator>().SetBool("move", true);
        fishman = gameObject.GetComponent<fishman>();
        fishman.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(runtime >= colddowntime)
        {
            fishtrigger = true;
            runtime = colddowntime;
        }

        runtime += Time.deltaTime;
        if (fishtrigger)
        {
            if (trigger)
            {
                this.GetComponent<Animator>().SetBool("move2", true);
            }
        }
        
    }
    public void fishmanon()
    {
        fishman.enabled = true;
    }
}
