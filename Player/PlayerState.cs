using UnityEngine;
using System.Collections;

public enum PLAYERSTATE
{
    SHIELDED,
    VUNERABLE,
}

public class PlayerState : MonoBehaviour {

    public PLAYERSTATE playerState;
    public float shieldTime = 3;
    float timer;
    GameObject boss;
    GameObject[] wallsOfDoom;

    // Use this for initialization
    void Start () {
        // Current State
        playerState = PLAYERSTATE.VUNERABLE;

        // Game Objects
        wallsOfDoom = GameObject.FindGameObjectsWithTag("Wall");
        boss = GameObject.FindWithTag("Boss");
    }
	
	// Update is called once per frame
	void Update () {

	
        switch(playerState)
        {
		case PLAYERSTATE.SHIELDED:
			Debug.Log ("Shielded");
            timer += Time.deltaTime;
                

        	foreach (GameObject wall in wallsOfDoom)
            {
            	wall.GetComponent<CapsuleCollider>().enabled = false;
            }

			if(timer >= shieldTime)
			{
				playerState = PLAYERSTATE.VUNERABLE;
			}

            break;

		case PLAYERSTATE.VUNERABLE:
			Debug.Log ("Vunerable");
            foreach (GameObject wall in wallsOfDoom)
            {
          	  	if(boss.GetComponent<SwapDimensions>().gameState == GAMESTATE.LIGHT)
              	{
                  if(wall.GetComponent<WallBehaviour>() != null)
                  {
                  		wall.GetComponent<CapsuleCollider>().enabled = true;
                  }
              	}
              	else if(boss.GetComponent<SwapDimensions>().gameState == GAMESTATE.DARK)
             	{
              		if (wall.GetComponent<DarkWallBehaviour>() != null)
                    {
                   		wall.GetComponent<CapsuleCollider>().enabled = true;
                    }
              	}
                    
               }
               break;

            default:
                Debug.Log("Player State BROKEN!!!!!!!");
                break;
        }
	}
}
