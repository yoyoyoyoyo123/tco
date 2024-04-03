using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inparent : MonoBehaviour
{
    public GameObject respawns;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        this.transform.localPosition = respawns.transform.position;
        this.transform.rotation = respawns.transform.rotation;
    }
}
