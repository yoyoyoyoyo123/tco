using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildon : MonoBehaviour
{
    public GameObject building;
    public GameObject[] buildings;
    public GameObject[] buildingposition;

    public GameObject[] crab;
    public bool one;
   
    // Start is called before the first frame update
    void Start()
    {
        building = GameObject.FindGameObjectWithTag("build");
        buildings = GameObject.FindGameObjectsWithTag("building");
        buildingposition = GameObject.FindGameObjectsWithTag("buildinglo");
    }

    // Update is called once per frame
    void Update()
    {
        crab = GameObject.FindGameObjectsWithTag("crab");
        

    }
    public void buildinghideoff()
    {
        building.gameObject.GetComponent<buildingmanger>().enabled = true;
    }

    public void buildingup()
    {
        for (int i = 0; i < 4; i++)
        {
            buildings[i].GetComponent<growvalue>().up = true;

        }
        
    }
}
