using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
    public GameObject projectile;


        void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Attack()
    {

        //var r = (GameObject)Instantiate(projectile,new Vector3(2,0), Quaternion.identity,transform);
        var r = Instantiate(projectile);
        r.transform.parent = transform;
        r.transform.localScale = new Vector3(1,1);
        r.transform.localPosition = new Vector3(2, 0);
        r.transform.localRotation = new Quaternion();

        r.GetComponent<Rigidbody2D>().AddForce(r.transform.TransformDirection(new Vector2(200, 0)));

        r.transform.parent = null;


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponentInParent<Player>();
        if (player != null)
        {
            player.currentWeapon = this;
            this.transform.parent = player.transform;
            this.transform.localPosition = new Vector3(0.5f, 0);
        }
    }
}
