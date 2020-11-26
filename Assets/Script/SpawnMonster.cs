using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour
{
    public GameObject PrefabEnemy;
    
    public float MaxSpawnYLimited = 4.5f;
    void Start()
    {
        StartCoroutine(Spawner());
     
    }

 



    IEnumerator Spawner()
    {
        while (true)
        {
            float random = Random.Range(-2, 6);

            Vector3 spawnpos = transform.position + new Vector3(12.4f, random, 0f);

            Instantiate(PrefabEnemy, spawnpos, Quaternion.identity);

           


            yield return new WaitForSeconds(1.5f);
        }

    }
}
