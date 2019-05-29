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
     void OnTriggerEnter2D(Collider2D hitInfo)
    {
       Enemy enemy = hitInfo.GetComponent<Enemy>();
        Destroy(gameObject);
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        
    }


}
