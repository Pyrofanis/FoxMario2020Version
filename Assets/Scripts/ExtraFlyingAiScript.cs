using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraFlyingAiScript : MonoBehaviour {
    private float timerOfThisGameObject=1, Axes = 0;
    public float velocityOfbox,timeTillRightSide,timeTillLeftSide,endLoopTimer;
    private float currentPosition, maxPosition, currentPositiony;
    private bool left, right;
        // Use this for initialization
    void Start () {
        currentPosition = gameObject.transform.position.x;
        currentPositiony = gameObject.transform.position.y;

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Axes += Time.deltaTime;
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(1 * velocityOfbox, Mathf.Cos((-Axes)) * velocityOfbox);
        timerOfThisGameObject += 0.5f;
        gameObject.GetComponent<SpriteRenderer>().flipX = true;
        if (timerOfThisGameObject >= timeTillRightSide)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-1 * velocityOfbox, Mathf.Cos((-Axes)) * velocityOfbox);
        }
        if (timerOfThisGameObject == timeTillLeftSide)
        {

            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(11 * velocityOfbox, Mathf.Cos((-Axes)) * velocityOfbox);
        }
        if (timerOfThisGameObject>= endLoopTimer) {
            timerOfThisGameObject = -0.5f;     
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            maxPosition= gameObject.transform.position.x;
            if (maxPosition != currentPosition)
            {
                gameObject.transform.position = new Vector2(currentPosition, gameObject.transform.position.y);
            }
        }

    }

}

