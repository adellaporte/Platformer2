using UnityEngine;
using System.Collections;

public class Bullets : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null)

            enemy.EnemyDie();
        this.gameObject.SetActive(false);
    }

            
       

    }
