using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondActivate : MonoBehaviour {

    private GameObject GM;

    void Start () {
        GM = GameObject.Find("Game Master");
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            GM.GetComponent<EnemyFollowPlayer1>().enabled = true;
        }
    }
}
