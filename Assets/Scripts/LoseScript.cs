
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//stil under development but needed in order for the checkpoints to work
public class LoseScript : MonoBehaviour
{
    public double timer;
    //the time which the death will last
    public double deathDelay;
    //ishit is used in case the object is been hit and free is used a a boolean that checks if the death delay is over
    public bool isHit = false,free;


    // Update is called once per frame
    void Update()
    {
        
        //it checks if the target is hit if it is a timer is started
        if (isHit)
        {
            timer += Time.deltaTime;
            //the time which it take before the respawn
            if (timer > deathDelay)
            {
             
                    isHit = false;
                    afterDeath();
                
            }
        }
        //when the timer gets greater than the time needed for the death to take place it Resets to 0
        if (timer >= deathDelay) { timer = 0; }

    }
  
    void OnCollisionEnter2D(Collision2D Coli)
    {
       // on trigger the is hit is set to true also the effects of thanatos start to take place also it checks if the gameObject sould die or not by the Collision with the enemy
        if (Coli.gameObject.tag.ToLower().Contains("enemy"))
        { if ((gameObject.transform.position.y - gameObject.transform.lossyScale.y/2) < (Coli.gameObject.transform.position.y + Coli.transform.lossyScale.y/4 ))
            {
              
                isHit = true;
                onDeath();
            }
            }
        }


        void OnTriggerEnter2D(Collider2D Coli)
    {
        
      
        //the same as above only this time is on the invisible deathzone this might change a tiny bit in the future if it starts causing problems and might only the ressurection part takes place
        if (Coli.gameObject.CompareTag("Death"))//de bgzw akri (petros)
        {
            gameObject.GetComponent<Checkpoints>().OnLoose(this.gameObject);
        }
    }


    //this method is used after death is over it turns off the animation and also reenables the collider the movement of the playerr the velocity and is set back to dynamic
    //also some variables are been reset and the onLooseMethod is called from checkpoints so the player will be teleported there
    private void afterDeath()
    {
        

        PlayerControl.Instance.animator.SetBool("Dead", false);
        gameObject.GetComponent<CapsuleCollider2D>().enabled = true;
        gameObject.GetComponent<PlayerControl>().enabled = true;
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
        free = true;
        gameObject.GetComponent<Checkpoints>().OnLoose(this.gameObject);

    }
    //this method is used in order for the player dead animation to start also disables the collider in order not to trigger another effect playermovement is 
    //also disabled since death and velocity is also set to zero in case the object was moving towards the enemy
    //no not currently nessecary also is set to kinematic since the object doesent has a collider and having been  set to kinematic is taken out of the simulation also free is false since the player is dead
    private void onDeath()
    {
        PlayerControl.Instance.animator.SetBool("Jump", false);
        PlayerControl.Instance.animator.SetBool("Dead", true);
        gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
        gameObject.GetComponent<PlayerControl>().enabled = false;
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        free = false;


    }
   

}
