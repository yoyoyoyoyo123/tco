using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    public string buildingTag = "Building"; // 要擊中的物體標籤
    public float rayLength = 100f; // 射線長度
    public GameObject build;
    private void Update()
    {
        // 從本物件位置發出一條射線
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        // 如果射線擊中了東西
        if (Physics.Raycast(ray, out hit, rayLength))
        {
            // 檢查擊中的物體是否有指定的標籤
            if (hit.collider.CompareTag(buildingTag))
            {
                build = hit.collider.gameObject;
                // 在控制台中顯示被擊中的物體的名稱
                Debug.Log("Hit building: " + hit.collider.gameObject.name);
            }
        }

        // 繪製射線，將其顯示為紅色
        Debug.DrawRay(ray.origin, ray.direction * rayLength, Color.red);
    }
}
