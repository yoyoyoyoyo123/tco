using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotkey : MonoBehaviour
{
    public GameObject crab;
    public GameObject crabposition;
    public GameObject crabmanager;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
           
    
            Instantiate(crab, new Vector3(crabposition.transform.position.x + Random.Range(-4.5f, 4.5f), crabposition.transform.position.y + Random.Range(-2.5f, 2.5f), crabposition.transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));


        }


        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            crabmanager.GetComponent<crabmove>().move = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

                  
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {

        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
           
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*
            fadeui.GetComponent<Animator>().enabled = true;
            fadeui.GetComponent<Animator>().SetBool("fadein", true);
            fadeui.GetComponent<Animator>().SetBool("fadeout", false);
            */
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            /*
            fadeui.GetComponent<Animator>().SetBool("fadeout",true);
            fadeui.GetComponent<Animator>().SetBool("fadein", false);
            */
        }
    }
}
