using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public LayerMask EnemyMask;
    public float speed = 1;
    Rigidbody2D myBody;
    Transform myTrans;
    float myWidth;

	// Use this for initialization
	void Start () {
        myTrans = this.transform;
        myBody = this.GetComponent<Rigidbody2D>();
        myWidth = this.GetComponent<SpriteRenderer>().bounds.extents.y;
	}
	
	// Update is called once per frame
	void FixedUpdate ()

    {
        Vector2 lineCastPos = myTrans.position - myTrans.right * myWidth;
        bool isGrounded = Physics2D.Linecast (lineCastPos, lineCastPos + Vector2.down, EnemyMask);

        if(!isGrounded)
        {
            Vector3 currRot = myTrans.eulerAngles;
            currRot.y += 180;
            myTrans.eulerAngles = currRot;

        }
        //Always move forward
        Vector2 myVel = myBody.velocity;
        myVel.x =-myTrans.right.y * speed;
        myBody.velocity = myVel;
	}
}
