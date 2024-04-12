using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float currentSpeed = 5;


        float moveHorizontal = Input.GetAxis("Horizontal") * currentSpeed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * currentSpeed * Time.deltaTime;


        float moveUpDown = 0f;
        if (Input.GetKey(KeyCode.Q)) { moveUpDown = -1f * currentSpeed * Time.deltaTime; }
        if (Input.GetKey(KeyCode.E)) { moveUpDown = 1f * currentSpeed * Time.deltaTime; }


        transform.Translate(moveHorizontal, moveUpDown, moveVertical);
    }
}
