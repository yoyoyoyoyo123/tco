using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishman : MonoBehaviour
{
    public float speed;
    public GameObject fishmanflok;
    public bool grown;
    public Material beman;
    public float grownspeed;
    public GameObject[] fishes;

    private void Start()
    {
        fishmanflok.SetActive(true);
    }
    void Update()
    {
        if (!grown)
        {
            fishmanflok.transform.Translate(Vector3.forward * speed * Time.deltaTime);
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
        }
        //visualEffect.SetFloat("Particle Edge", -shininess );
        beman.SetFloat("_cutedge", grownspeed);
    }
}
