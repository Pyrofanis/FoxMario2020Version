using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCratesVisible : MonoBehaviour {

    private bool destroy = true;

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Player"))
        {
            if(gameObject.GetComponent<SpriteRenderer>().enabled == true && destroy)
            {
                gameObject.SetActive(false);
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
                destroy = false;
            }
        }

    }

}
