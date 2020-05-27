using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer1 : MonoBehaviour {

    private float followingEnemySpeed = 5.5f;
    private float followtimer = 0;
    private float rayDistance = 0.8f;

    private int enemyJumpingPower = 90;

    private Vector3 playerPosition;
    public GameObject Player;
    public List<GameObject> FollowingEnemy;
	

	void Update () {

        //makes the enemy disappear after some seconds of chasing
        followtimer += Time.deltaTime;
        if (followtimer > 4)
        {
            foreach (GameObject enemy in FollowingEnemy)
            {
                enemy.SetActive(false);
            }
            gameObject.GetComponent<EnemyFollowPlayer1>().enabled = false;

        }

        //creating rays that detect obstacles for all the enemies,so that they can avoid them(jump) 
        //RaycastHit2D rayRight1 = Physics2D.Raycast(FollowingEnemy[0].transform.position, Vector2.right); RaycastHit2D rayRight2 = Physics2D.Raycast(FollowingEnemy[1].transform.position, Vector2.right);
        //RaycastHit2D rayRight3 = Physics2D.Raycast(FollowingEnemy[2].transform.position, Vector2.right); RaycastHit2D rayLeft1 = Physics2D.Raycast(FollowingEnemy[0].transform.position, Vector2.left);
        //RaycastHit2D rayLeft2 = Physics2D.Raycast(FollowingEnemy[1].transform.position, Vector2.left); RaycastHit2D rayLeft3 = Physics2D.Raycast(FollowingEnemy[2].transform.position, Vector2.left);
        //if ( ((rayLeft1.collider.tag == "Ground" || rayLeft1.collider.tag == "Box") && rayLeft1.distance<rayDistance) || ((rayRight1.collider.tag == "Ground" || rayRight1.collider.tag == "Box") && rayRight1.distance < rayDistance) )
        //{
        //    FollowingEnemy[0].GetComponent<Rigidbody2D>().AddForce(new Vector2(0, enemyJumpingPower));
        //}
        //if (((rayLeft2.collider.tag == "Ground" || rayLeft2.collider.tag == "Box") && rayLeft2.distance < rayDistance) || ((rayRight2.collider.tag == "Ground" || rayRight2.collider.tag == "Box") && rayRight2.distance < rayDistance))
        //{
        //    print("yes");
        //    FollowingEnemy[1].GetComponent<Rigidbody2D>().AddForce(new Vector2(0, enemyJumpingPower));
        //}
        //if (((rayLeft3.collider.tag == "Ground" || rayLeft3.collider.tag == "Box") && rayLeft3.distance < rayDistance) || ((rayRight3.collider.tag == "Ground" || rayRight3.collider.tag == "Box") && rayRight3.distance < rayDistance))
        //{
        //    FollowingEnemy[2].GetComponent<Rigidbody2D>().AddForce(new Vector2(0, enemyJumpingPower));
        //}
        //if (rayLeft2.distance <0.8f && rayLeft2.collider.CompareTag("Ground"))
        //{
        //    print(rayLeft2.collider.tag);
        //    FollowingEnemy[1].GetComponent<Rigidbody2D>().AddForce(new Vector2(0, enemyJumpingPower));
        //}

        //makes every enemy go towards the current position of the player
        playerPosition = Player.transform.position;
        foreach(GameObject enemy in FollowingEnemy)
        {
            if (System.Math.Abs(enemy.transform.position.x - playerPosition.x) < 11)
            {
                enemy.transform.position = Vector2.MoveTowards(enemy.transform.position, playerPosition, followingEnemySpeed * Time.deltaTime);
                transform.right = enemy.transform.position - playerPosition;
            }
        }
	}

}
