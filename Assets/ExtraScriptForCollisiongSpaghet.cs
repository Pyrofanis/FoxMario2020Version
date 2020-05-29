using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraScriptForCollisiongSpaghet : MonoBehaviour
{
    private Animator anime;
    public GameObject deathPanel;
    public float depnlDelay;
    private Vector2 initialPosition;
    private GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        anime = GetComponent<Animator>();
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    IEnumerator DeathpanelControllerDelay()
    {
        yield return new WaitForSeconds(depnlDelay);
        deathPanel.SetActive(true);

    }
    private void OnTriggerEnter2D(Collider2D collider) {
        if (collider.CompareTag("Death"))
        {
            transform.position = initialPosition;
            camera.transform.position = initialPosition;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            anime.SetBool("Dead",true);
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            GetComponent<PlayerControl>().enabled=false;
            StartCoroutine(DeathpanelControllerDelay());
        }
    }
}
