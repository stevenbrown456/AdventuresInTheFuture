using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 100;


	// Use this for initialization
	void Start () {
        rb.velocity = transform.right * speed;
		
	}
    //when trigger is pressed the bullet will fire
     void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //this make sure the the bullet detects an object, if object is enemy it will destroy enemy
       Enemy enemy = hitInfo.GetComponent<Enemy>();
        Destroy(gameObject);
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        
    }


}
