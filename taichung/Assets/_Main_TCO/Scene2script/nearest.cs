using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nearest : MonoBehaviour
{
    
    public GameObject[] allEnemies;
    public GameObject closestEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }




    // Update is called once per frame
    void Update()
    {
        allEnemies = GameObject.FindGameObjectsWithTag("crab");
        closestEnemy = ClosestEnemy();
        //print(closestEnemy.name);
    }


    GameObject ClosestEnemy()
    {

        GameObject closestHere = gameObject;
        float leastDistance = Mathf.Infinity;

        foreach (var enemy in allEnemies)
        {

            float distanceHere = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceHere <=  leastDistance)
            {
                leastDistance = distanceHere;
                closestHere = enemy;
            }


        }




        return closestHere;
    }
}
