using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraFoundTrap : MonoBehaviour {
    private int enemyOrientation;
    public GameObject player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //checks the orientation per frame
        if (gameObject.transform.position.x > player.transform.position.x)
        {
            enemyOrientation = -1;

        }
        else if (gameObject.transform.position.x < player.transform.position.x)
        {
            enemyOrientation = 1;

        }
        //adds force every time it reaches the set distance
        if (Mathf.Abs(gameObject.transform.position.x - player.transform.position.x) > 5)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(20 * enemyOrientation, 0.0f));


        }
    }
}
