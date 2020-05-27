using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraScriptForCollisiongSpaghet : MonoBehaviour
{
    private Animation anime;
    public GameObject deathPanel;
    public float depnlDelay;
    private Vector2 initialPosition;
    private GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        anime = GetComponent<Animation>();
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (anime.clip.name.ToLower().Contains("death"))
        {
            DeathpanelControllerDelay();
        }
        
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
}
