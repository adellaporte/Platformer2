using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour
{
    public int numHits = 3;
    public GameObject prize;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        numHits--;

        if (numHits == 0)
        {
            this.gameObject.SetActive(false);
          
            if (prize != null)
            {
                Instantiate(prize, transform.position, Quaternion.identity);
            }

        }

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
