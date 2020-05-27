using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCameraMovementScript : MonoBehaviour {
    public GameObject CameraObject,player;
    public float  CameraSettingY;
    // Use this for initialization
    void Start () {

      

    }
	
	// Update is called once per frame
	void Update () {
        //if the gameobject moves so does and the camera
        if (PlayerControl.Instance.rb.velocity.x > 0 && Mathf.Abs((player.transform.position.x) - (CameraObject.transform.position.x)) >= 14)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(PlayerControl.Instance.rb.velocity.x, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        }
        if (Mathf.Abs((player.transform.position.x) - (CameraObject.transform.position.x)) >= 14)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(10, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        }
        //else if player is iddle or moving towards the collider the camera stops moving
        else if (PlayerControl.Instance.rb.velocity.x <= 0 || PlayerControl.Instance.rb.velocity.x <= 14)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        }
        //the same as is was before
        if (Mathf.Abs(gameObject.transform.position.y + 7 - player.transform.position.y) >= 15)
        {  //an h thesi tou y toy pexti einai megaliteri apo ayth ths kameras tote dn metakinite
            if (player.transform.position.y > gameObject.transform.position.y)
            {
                gameObject.transform.Translate(0.0f, 0.0f, 0.0f);
            }
            //an h thesi tou pexti einai mikroteri ths kameras tote metakinite
            else if (player.transform.position.y < gameObject.transform.position.y - 3)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, player.transform.position.y + CameraSettingY, -2);
            }

        }



    }



}

