using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerLoose : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D OtherObject)
    {
        if (OtherObject.gameObject.name.ToLower().Contains("huntah"))
        {
            gameObject.SetActive(false);
        }
    }
}
