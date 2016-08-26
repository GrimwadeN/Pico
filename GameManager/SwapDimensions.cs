using UnityEngine;
using System.Collections;

public enum GAMESTATE
{
    LIGHT,
    DARK,
}

public class SwapDimensions : MonoBehaviour {

    GameObject[] wallsOfDoom;
    public GAMESTATE gameState;
    GameObject UI;
    float score;
    GameObject flyingObjectOfDoom;

    private Changer c;
    private changerlight cl;


	// Use this for initialization
	void Start () {
        wallsOfDoom = GameObject.FindGameObjectsWithTag("Wall");
        gameState = GAMESTATE.LIGHT;
        UI = GameObject.FindWithTag("UI");
        flyingObjectOfDoom = GameObject.FindWithTag("FlyingDoom");
        
        c = FindObjectOfType<Changer>();
        cl = FindObjectOfType<changerlight>();
      
        c.changedark();
        cl.changedark();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonUp("Jump"))
        {
            // Swap colliders and textures
            foreach (GameObject wall in wallsOfDoom)
            {
                if (wall.GetComponent<WallBehaviour>() != null)
                {
                    wall.GetComponent<WallBehaviour>().SwapState();
                }

                if (wall.GetComponent<DarkWallBehaviour>() != null)
                {
                    wall.GetComponent<DarkWallBehaviour>().SwapState();
                }

            }

            // If space bar is pressed swap between states
            SwapGameState();
        }        

        switch(gameState)
        {
            case GAMESTATE.DARK:
           
                c.changedark();
                cl.changedark();
                // Make flying things attack player
                //ToDoomOrNotToDoom(true);

                // Gain points in darkstate
                // UI.GetComponentInChildren<Score>().points += 1;
                break;

            case GAMESTATE.LIGHT:
              
                c.changelight();
                cl.changelight();
                // Flying things do nothing
                // ToDoomOrNotToDoom(false);
                break;
        }
    }

    void SwapGameState()
    {
        if(gameState == GAMESTATE.LIGHT)
        {
            gameState = GAMESTATE.DARK;
            
        }
        else
        {
            gameState = GAMESTATE.LIGHT;
            
        }
    }

    void ToDoomOrNotToDoom(bool gloom)
    {
        if (gloom)
        {
            flyingObjectOfDoom.GetComponent<GhostlyBehaviour>().behaviourState = BEHAVIOURSTATE.EVIL;
        }
        else
        {
            flyingObjectOfDoom.GetComponent<GhostlyBehaviour>().behaviourState = BEHAVIOURSTATE.GOOD;
        }
    }
}
