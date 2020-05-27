 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Temporary solution
public class TriggerColliderCameraScript : MonoBehaviour {
    //private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //i takes the collided object and it teleports it 1pxl to the right
    void OnTriggerEnter2D(Collider2D objectCollided)
    {
        //rb = objectCollided.GetComponent<Rigidbody2D>();
        if (objectCollided.tag.ToLower().Contains("player"))
        {
            Debug.Log("it M8 Work");
                //rb.velocity = new Vector2(0, 0);
            objectCollided.transform.position =new Vector3(objectCollided.transform.position.x+0.4f, objectCollided.transform.position.y,1);
        }
    }

}
