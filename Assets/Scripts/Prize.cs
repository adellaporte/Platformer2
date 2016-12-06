using UnityEngine;
using System.Collections;

public class Prize : MonoBehaviour
{
    public int worth = 2;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        FindObjectOfType<GM>().CoinWasPickedUp(worth);

    }
}