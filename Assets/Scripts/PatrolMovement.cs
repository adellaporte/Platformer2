using UnityEngine;
using System.Collections;

public class PatrolMovement : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    Vector3 direction = new Vector3(-1, -.1f);
   
    void Update()
    {
        
        transform.position += direction * Time.deltaTime;

        if (transform.position.x <= 0) {
            direction = new Vector3(1, .1f);
         }

        if (transform.position.x >= 5) {
            direction = new Vector3(-1, -.1f);
        }
        
    }
}
