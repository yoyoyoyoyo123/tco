using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplaySwitcher : MonoBehaviour
{
    public Camera maincamera;
    public Camera VRcamera;
    public Canvas canvas;
    
    void Update()
    {
        // 如果按下了M键
        if (Input.GetKeyDown(KeyCode.M))
        {
            maincamera.targetDisplay = 0;
            VRcamera.targetDisplay = 1;
            canvas.targetDisplay = 1;
        }

       
    }
    


}
