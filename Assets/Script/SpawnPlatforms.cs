using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatforms : MonoBehaviour
{
    public float[] position = { 4.54f,2.61f,-1.24f,0.18f };
    public GameObject[] platforms;
    void Start()
    {
        StartCoroutine( Spawn ());
    }

    // Update is called once per frame
   IEnumerator Spawn ()
    {
        while (true)
        {

            Instantiate(platforms[Random.Range(0, platforms.Length)], new Vector3 (15.82f, position[Random.Range(0, 3)], 0), Quaternion.identity);

            yield return new WaitForSeconds(2.5f);
        }
       
    }
}
