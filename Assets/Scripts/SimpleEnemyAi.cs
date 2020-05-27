using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyAi : MonoBehaviour {
    public float velocityOfGAMEobject;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(velocityOfGAMEobject, 0);
        if (gameObject.GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (gameObject.GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        velocityOfGAMEobject = -velocityOfGAMEobject;
    }
}
