using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBoxAI : MonoBehaviour
{

    private float Axes = 0;
    public float VelocityOfbox;
    [Range(-1,1)]
    public float orientation = 1;
    public List<GameObject> flyingBoxes = new List<GameObject>();
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Axes+=Time.deltaTime;
        flyingBoxes[0].GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Sin((Axes)) * VelocityOfbox, Mathf.Cos(( Axes)) * VelocityOfbox);//κυκλικο
        flyingBoxes[2].GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Sin((Axes)) * VelocityOfbox, Mathf.Cos((Axes)) * VelocityOfbox);//κυκλικο
        flyingBoxes[1].GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Sin((-Axes)) * VelocityOfbox, Mathf.Cos(( -Axes)) * VelocityOfbox);//κυκλικο
        flyingBoxes[3].GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Cos((Axes)) * VelocityOfbox, Mathf.Cos(( Axes)) * VelocityOfbox);

    }
}

