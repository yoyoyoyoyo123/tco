using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotkey : MonoBehaviour
{
    public GameObject crab;
    public GameObject crabposition;
    public GameObject crabmanager;
    public GameObject[] crabs;
    public int crabcount;
    public GameObject headset;
    public GameObject raycast;
    public GameObject VRcam;
    public GameObject maincamera;
    public GameObject fadeui;
    private int lookcount;
    // Start is called before the first frame update
    void Start()
    {
        crabcount = -1;
    }

    // Update is called once per frame
    void Update()
    {
        crabs = GameObject.FindGameObjectsWithTag("crab");
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            Instantiate(crab,headset.transform.position , Quaternion.Euler(new Vector3(0, 0, 0)));
            //Instantiate(crab, new Vector3(crabposition.transform.position.x + Random.Range(-4.5f, 4.5f), crabposition.transform.position.y , crabposition.transform.position.z + Random.Range(-2.5f, 2.5f)), Quaternion.Euler(new Vector3(0, 0, 0)));


        }


        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (VRcam.GetComponent<nearest>().closestEnemy.GetComponent<crabmove>() != null)
            {
                VRcam.GetComponent<nearest>().closestEnemy.GetComponent<crabmove>().move = true;
            }
           



        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if(raycast.GetComponent<raycast>().build.GetComponent<growvalue>() != null)
            {
                raycast.GetComponent<raycast>().build.GetComponent<growvalue>().grow = true;
            }
            


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
            
            fadeui.GetComponent<Animator>().enabled = true;
            fadeui.GetComponent<Animator>().SetBool("fadein", true);
            fadeui.GetComponent<Animator>().SetBool("fadeout", false);
            
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            
            fadeui.GetComponent<Animator>().SetBool("fadeout",true);
            fadeui.GetComponent<Animator>().SetBool("fadein", false);        
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            lookcount += 1;
            if(lookcount > 1)
            {
                lookcount = 0;
            }
            if(lookcount == 0)
            {
                maincamera.GetComponent<lookat>().look = false;
            }
            else if(lookcount == 1)
            {
                maincamera.GetComponent<lookat>().look = true;
            }
            

        }
    }
}
