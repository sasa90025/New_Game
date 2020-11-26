using System.Collections;
using UnityEditor;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject background;
    public float speed = 2f;
    void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < -20.53f)
        {
            
           // EditorApplication.isPaused = true;
           Instantiate(background, new Vector3(41.35f,1.8f,0),Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
