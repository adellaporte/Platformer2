using UnityEngine;
using System.Collections;

public class Flag : MonoBehaviour
{
    public int numHits = 1;


    public void OnCollisionEnter2D(Collision2D collision)
    {

        numHits--;

        if (numHits == 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}