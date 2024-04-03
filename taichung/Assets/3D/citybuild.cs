using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class citybuild : MonoBehaviour
{
    public Material material;
    public Material dissolve;
    public float shininess;
    public float edge;
    public bool up;
    public GameObject fishmanager;
    public float runtime;

    public float fishruntime;

    //public GameObject mcamera;
    // Start is called before the first frame update
    void Start()
    {
        shininess = 8f;
        material.SetFloat("_cut", shininess);
        edge = 1;
        dissolve.SetFloat("_cutedge", edge);
    }

    // Update is called once per frame
    void Update()
    {
        if (up)
        {
            edge -= Time.deltaTime * 2f;

            if(runtime >= 1)
            {
                if (shininess <= 119.24f)
                {
                    shininess += Time.deltaTime * 50f;
                }
                runtime = 1;
            }
            runtime += Time.deltaTime;


        }
        if (shininess >= 119.24f)
        {
            shininess = 120f;
            if(fishruntime >= 1.5f)
            {
                fishmanager.GetComponent<fishmanager>().enabled = true;
                fishruntime = 1.5f;
            }
            fishruntime += Time.deltaTime;
        }
        if (edge <= -1)
        {
            edge = -2;
        }
        material.SetFloat("_cut", shininess);
        dissolve.SetFloat("_cutedge", edge);

    }
}
