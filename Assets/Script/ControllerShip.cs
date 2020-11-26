using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerShip : MonoBehaviour
{

    public GameObject Shutprefab;
    float elapsedTime = 0f;
    float reloadTime = 1.5f;
   
    
   


    void Update()
    {

        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        transform.position = new Vector3(transform.position.x, pos.y,  transform.position.z);

        elapsedTime += Time.deltaTime;

      if ( elapsedTime>reloadTime)
        {
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(2.5f, 0,0);
            Instantiate(Shutprefab,spawnPos,Quaternion.identity);
          

            elapsedTime = 0f;
        }
    }
}
