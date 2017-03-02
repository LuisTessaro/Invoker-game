using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour {


    public Vector2 speed;
    public Rigidbody2D rb;
    public string type;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity -= speed;
    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity -= speed * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (gameObject.tag == type && coll.gameObject.tag == type)
        {
            Destroy(gameObject);
        }
    }


}
