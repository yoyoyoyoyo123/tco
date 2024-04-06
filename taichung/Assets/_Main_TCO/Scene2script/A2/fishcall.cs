using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishcall : MonoBehaviour
{
    public GameObject fishmanager;
    public float humanspeed;
    public bool trigger;
    // Start is called before the first frame update
    void Start()
    {
        if (trigger)
        {
            this.GetComponent<Animator>().SetBool("walk", true);
            Destroy(this.gameObject, 13);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            this.transform.Translate(Vector3.forward * humanspeed * Time.deltaTime);
        }
        
        
    }
    public void walk()
    {
        fishmanager.GetComponent<fishman>().walkbool = true;
    }
}
