using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotkey : MonoBehaviour
{
    public GameObject crab;
    public GameObject crabposition;
    public GameObject crabman;
    public GameObject[] buildings;
    public GameObject city;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        crabman = GameObject.FindGameObjectWithTag("crabman");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            for (int i = 0; i < 4; i++)
            {
                Instantiate(crab, new Vector3(crabposition.transform.position.x + Random.Range(-0.15f,0.15f) , crabposition.transform.position.y + Random.Range(-0.1f, 0.1f), crabposition.transform.position.z), Quaternion.Euler(new Vector3(90, 0, 0)));

            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < 4; i++)
            {

                crabman.GetComponent<crabmove>().crabs[i].GetComponent<crabwalk>().walk = false;
            }
            crabman.GetComponent<crabmove>().move = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            for (int i = 0; i < 4; i++)
            {
                buildings[i].GetComponent<growvalue>().grow = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            for (int i = 0; i < 4; i++)
            {
                city.GetComponent<citybuild>().up = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            cam.GetComponent<Animator>().SetBool("move2", true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            cam.GetComponent<fishman>().grown = true;
        }
    }
}
