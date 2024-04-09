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
        
        
        buildingposition = GameObject.FindGameObjectsWithTag("buildinglo");
    }

    // Update is called once per frame
    void Update()
    {
        crab = GameObject.FindGameObjectsWithTag("crab");
        buildings = GameObject.FindGameObjectsWithTag("building");

    }
    public void buildinghideoff()
    {
        Destroy(this.gameObject,1);
    }

    public void buildingup()
    {
        GameObject buildings1 =  Instantiate(building, this.transform.position, Quaternion.Euler(-90f, 0f, 0f));
        buildings1.GetComponent<growvalue>().up = true;

        //buildings[0].GetComponent<growvalue>().up = true;
    }
}
