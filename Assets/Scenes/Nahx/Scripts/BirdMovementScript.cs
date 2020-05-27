using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BirdMovementScript : MonoBehaviour
{
    public float speed;
    private Vector2 initialPosition,currentLocation;
    public Transform objectiveLoc;
    public float minimuDistanceToReturn;
    private float distanceAtRunTime, DistanceAtStart;
    public bool returnBird;
    private SpriteRenderer sb;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        DistanceAtStart = Mathf.Abs(currentLocation.x - objectiveLoc.position.x);
        sb = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        currentLocation = new Vector2(transform.position.x,transform.position.y);
        distanceAtRunTime=Mathf.Abs(currentLocation.x - objectiveLoc.position.x);
        if (returnBird)
        {
            flyingMovement(initialPosition);
        }
        else flyingMovement(objectiveLoc.transform.position);

    }
    void flyingMovement(Vector2 targetedLocation)
    {
        transform.position = Vector2.MoveTowards(transform.position, targetedLocation, speed * Time.deltaTime);
    }
    
 private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("LeftBirdCollider"))
        {
            returnBird = true;
            sb.flipX = true;
        }
        if (collider.CompareTag("RightBirdCollider"))
        {
            returnBird = false;
            sb.flipX = false;

        }


    }
}
