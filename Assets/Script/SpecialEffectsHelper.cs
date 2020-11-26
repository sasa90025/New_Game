using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialEffectsHelper : MonoBehaviour
{
    public static SpecialEffectsHelper Instance;
    public ParticleSystem smoke;
    public ParticleSystem fire;

    void Start()
    {
        
    }

    
    void Awake ()
    {
       if (Instance != null) 
        {
            Debug.LogError("Несколько экземпляров");
        }

        Instance = this;
    }

    public void Explosion(Vector3 position)
    {
        instantiate(smoke, position);
        instantiate(fire, position);

    }

    private ParticleSystem instantiate (ParticleSystem prefab, Vector3 position)
    {
        ParticleSystem newParticleSystem = Instantiate(prefab,position,Quaternion.identity) as ParticleSystem;
        Destroy(newParticleSystem.gameObject, newParticleSystem.startLifetime);
        return newParticleSystem;
    }
}
