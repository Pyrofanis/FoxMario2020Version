using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{
    public GameObject player,cameraObject;
    //cameraSetting einai metabliti poy theti thn kamera sto simio to opoio theloyme na dinete h oratotita ston pexti
    //cameraSettingY dinoyme thn diafora ths apostasis poy eixe eksarxis o pextis me thn kamera etsi oste an pesi o pextis na eksisoropistoi pali i apostasi ths cameras apo ayton
    public float CameraSetting, CameraSettingY;

    
    //Use this for initialization

void Start()
    {
       
    }

    //Update is called once per frame
    void Update()
    {
        

        //kanei elenxo metaksi apostasis tou object ths cameras kai toy x toy pextei kai an kseperastei tote metabalete o x aksonas
        if (Mathf.Abs((player.transform.position.x)-(cameraObject.transform.position.x )) >= 17  )
        {
            //kanei metafora ton x aksona ths kameras ton proxoraei dld dn to thlemetaferei 
        
                gameObject.transform.Translate((player.transform.position.x - CameraSetting) * Time.deltaTime*3, 0.0f, -2);

            
        }
        //opos kai apo epanno an kseperasti mia timh dosmenh apostaseis pexti me kameras energopiite o kombos
        if (Mathf.Abs(gameObject.transform.position.y+7 - player.transform.position.y) >= 10)
        {  //an h thesi tou y toy pexti einai megaliteri apo ayth ths kameras tote dn metakinite
            if (player.transform.position.y > gameObject.transform.position.y)
            {   
                gameObject.transform.Translate(0.0f, 0.0f, 0.0f);
            }
            //an h thesi tou pexti einai mikroteri ths kameras tote metakinite
            else if(player.transform.position.y < gameObject.transform.position.y-3)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, player.transform.position.y + CameraSettingY, -2);
            }

        }


    }

}