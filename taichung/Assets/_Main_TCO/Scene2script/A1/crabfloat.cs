using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crabfloat : MonoBehaviour
{
    // 最大推力和旋轉力
    public float m_Thrust = 3f;
    public float maxTorque;



    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ApplyRandomForce();
        ApplyRandomTorque();

    }

     void Update()
    {
        //ApplyRandomForce();
    }

    void ApplyRandomForce()
    {
        rb.AddForce(transform.up * -m_Thrust);
    }

    void ApplyRandomTorque()
    {
        Vector3 torque = Random.insideUnitSphere * maxTorque;
        rb.AddTorque(torque, ForceMode.Impulse);
    }

}
