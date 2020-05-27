using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraObjectCollider : MonoBehaviour {
    public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D Otherobject)
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        if (Otherobject.name.ToLower().Contains("player"))
        {
            Debug.Log("-100, 0");
            rb.velocity = new Vector2(-rb.velocity.x, 0);
            
        }
    }
}
