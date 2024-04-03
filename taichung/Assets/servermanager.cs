using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class servermanager : MonoBehaviour
{
    public GameObject[] respawns;
    public List<GameObject> mList = new List<GameObject>();
    public bool onetime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        respawns = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject line in respawns) //一項一項讀取
        {
            if(mList.Count < respawns.Length)
            {
                mList.Add(line);
            }
        }




    }
}
