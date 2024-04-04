using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crabwalk : MonoBehaviour
{
    public float speed; // 移动速度
    public float boundaryX ;
    public bool walk;
    public float ox;
    public bool one;
    // Start is called before the first frame update
    void Start()
    {
        boundaryX = Random.Range(0.01f, 0.03f);
        speed = Random.Range(0.001f, 0.003f);
    }

    // Update is called once per frame
    void Update()
    {
        if (walk)
        {
            if(one == false)
            {
                ox = transform.position.x;
                one = true;
            }
            
            float movement = speed * Time.deltaTime;
            transform.Translate(Vector3.right * movement);

            // 如果物体的X位置超出了边界位置，将其移动方向反转
            if (transform.position.x >= ox + boundaryX || transform.position.x <= ox - boundaryX)
            {
                Debug.Log("hi");
                speed = -speed; // 反转移动速度
            }
        }
    }
}
