using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D> ();
        rigidbody.velocity = new Vector2(speed, 0f);
        Destroy(gameObject,3);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        SpecialEffectsHelper.Instance.Explosion(transform.position);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
