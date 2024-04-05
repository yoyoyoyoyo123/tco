using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishman : MonoBehaviour
{
    public float fishspeed;
    public float humanspeed;
    public GameObject fishmanflok;
    public bool grown;
    public Material beman;
    public float grownspeed;
    public GameObject[] fishes;
    public GameObject[] fishemans;
    public Vector3 orgiposition;

    public float runtime;

    public float holdtime;

    public GameObject fishmanprefab;
    public bool spawn;
    public bool spawnbool2;
    public GameObject spawn1;
    public GameObject spawn2;
    public float spawncolddowntime;
    public float spawnruntime;
    public float spawncolddowntime2;
    public float spawnruntime2;
    public bool walkbool;

    public GameObject fishpri;
    private void Start()
    {
        fishmanflok.SetActive(true);
        orgiposition = fishmanflok.transform.position;
        grownspeed = 0;
    }
    void Update()
    {
        if (!grown)
        {
            for (int i = 0; i < 4; i++)
            {
                fishmanflok.transform.Translate(Vector3.forward * fishspeed * Time.deltaTime);
            }
            
            if(fishmanflok.transform.position.z >= 18f)
            {
                fishmanflok.transform.position = orgiposition;
            }
        }
        else
        {
            for (int i = 0; i < 4; i++)
            {

                fishes[i].GetComponent<Animator>().enabled = false;
            }
            if (grownspeed < 0.35f)
            {
                grownspeed -= Time.deltaTime * 0.35f;
            }

        }


        if (grownspeed <= -1.24f)
        {
            grownspeed = -1.24f;
            for (int i = 0; i < 4; i++)
            {
                fishemans[i].GetComponent<Animator>().SetBool("walk", true);

            }
            if (runtime >= holdtime)
            {
                               
                this.GetComponent<Animator>().SetBool("watch", true);
                runtime = holdtime;
            }
            runtime += Time.deltaTime;


        }
        //visualEffect.SetFloat("Particle Edge", -shininess );
        beman.SetFloat("_cutedge", grownspeed);
        if (walkbool)
        {
            fishmanflok.transform.Translate(Vector3.forward * humanspeed * Time.deltaTime);
        }
        
        if (spawn)
        {
           if(spawnruntime >= spawncolddowntime)
            {
               GameObject fishmans = Instantiate(fishmanprefab, spawn1.transform.position, spawn1.transform.rotation);
                fishmans.GetComponent<fishcall>().trigger = true;

                spawnruntime = 0;
            }
            spawnruntime += Time.deltaTime;
        }
        if (spawnbool2)
        {
            if (spawnruntime2 >= spawncolddowntime2)
            {
                GameObject fishmans = Instantiate(fishmanprefab, spawn2.transform.position, spawn2.transform.rotation);
                fishmans.GetComponent<fishcall>().trigger = true;

                spawnruntime2 = 0;
            }
            spawnruntime2 += Time.deltaTime;
        }
    }

    public void spawnfishman()
    {
        spawn = true;
    }
    public void spawnfishman2()
    {
        spawnbool2 = true;
        fishpri.SetActive(true);
    }
}
