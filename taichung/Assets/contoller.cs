using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class contoller : MonoBehaviour
{
    Scene m_Scene;
    public GameObject[] eye;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (OVRInput.Get(OVRInput.Button.One))
        {
            eye[0].GetComponent<LineRenderer>().enabled = true;
            eye[1].GetComponent<LineRenderer>().enabled = true;
        }
        else
        {
            eye[0].GetComponent<LineRenderer>().enabled = false;
            eye[1].GetComponent<LineRenderer>().enabled = false;
        }
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            SceneManager.LoadScene("DemoServerRpcAndClientRpc");


        }

        
    }
}
