using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatest : MonoBehaviour
{
    public float rotationSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I)) // 你可以更改为其他按键
        {
            // 获取物体的Transform组件
            Transform myObjectTransform = transform;

            // 计算旋转增量
            float rotationAmount = -rotationSpeed * Time.deltaTime;

            // 增加绕X轴的旋转
            myObjectTransform.Rotate(new Vector3(rotationAmount, 0, 0));
        }
        if (Input.GetKey(KeyCode.K)) // 你可以更改为其他按键
        {
            // 获取物体的Transform组件
            Transform myObjectTransform = transform;

            // 计算旋转增量
            float rotationAmount = rotationSpeed * Time.deltaTime;

            // 增加绕X轴的旋转
            myObjectTransform.Rotate(new Vector3(rotationAmount, 0, 0));
        }
        if (Input.GetKey(KeyCode.L)) // 你可以更改为其他按键
        {
            // 获取物体的Transform组件
            Transform myObjectTransform = transform;

            // 计算旋转增量
            float rotationAmount = rotationSpeed * Time.deltaTime;

            // 增加绕X轴的旋转
            myObjectTransform.Rotate(new Vector3(0, rotationAmount, 0));
        }
        if (Input.GetKey(KeyCode.J)) // 你可以更改为其他按键
        {
            // 获取物体的Transform组件
            Transform myObjectTransform = transform;

            // 计算旋转增量
            float rotationAmount = -rotationSpeed * Time.deltaTime;

            // 增加绕X轴的旋转
            myObjectTransform.Rotate(new Vector3(0, rotationAmount, 0));
        }
    }
}
