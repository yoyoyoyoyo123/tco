using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crabmove : MonoBehaviour
{
    public bool move;
    public GameObject[] crabs;
    public GameObject[] buildings;
    public float runtime;
    public float timemove;
    public GameObject midfinger;
    public float duration = 3f;
    public bool one;
    public float timer = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        midfinger = GameObject.Find("midL ");

    }

    // Update is called once per frame
    void Update()
    {
        crabs = GameObject.FindGameObjectsWithTag("crab");

        buildings = GameObject.FindGameObjectsWithTag("buildinglo");
       


        if (move)
        {
            if(crabs[0] != null)
            {
                //crabs[0].transform.localScale = Vector3.Lerp(crabs[0].transform.localScale, new Vector3(2.354562f, 2.354562f, 2.354562f), timer * 0.0004f);
            }
            if (crabs[1] != null)
            {
                //crabs[1].transform.localScale = Vector3.Lerp(crabs[0].transform.localScale, new Vector3(2.354562f, 2.354562f, 2.354562f), timer * 0.0004f);
            }
            if (crabs[2] != null)
            {
                //crabs[2].transform.localScale = Vector3.Lerp(crabs[0].transform.localScale, new Vector3(2.354562f, 2.354562f, 2.354562f), timer * 0.0004f);
            }
            if (crabs[3] != null)
            {
                //crabs[3].transform.localScale = Vector3.Lerp(crabs[0].transform.localScale, new Vector3(2.354562f, 2.354562f, 2.354562f), timer * 0.0004f);
            }

            timer += Time.deltaTime;
            for (int i = 0; i < 4; i++)
            {

                //crabs[i].transform.rotation = Quaternion.Lerp(crabs[i].transform.rotation, Quaternion.Euler(90, 0, 90), 0.04f);
                //timer += Time.deltaTime;
                crabs[i].GetComponent<Animator>().enabled = true;
                crabs[i].GetComponent<Animator>().SetBool("becomehouse", true);
        
                midfinger.GetComponent<midtri>().allowtrigger = true;
            }

            if (runtime >= timemove)
            {
                for (int i = 0; i < 4; i++)
                {

                    crabs[i].transform.position = Vector3.MoveTowards(crabs[i].transform.position, buildings[i].transform.position, 0.05f);
                }
               
                runtime = timemove;
            }
            runtime += Time.deltaTime;
        }
        

    }

    
}
