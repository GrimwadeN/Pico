using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public enum BEHAVIOURSTATE
{
    GOOD,
    EVIL,
}

public class GhostlyBehaviour : MonoBehaviour {
    [Header("DONT TOUCH")]
    public BEHAVIOURSTATE behaviourState;
    GameObject player;
    [Header("Enemy Movespeed")]
    public float speed;

	// Use this for initialization
	void Start () {
        behaviourState = BEHAVIOURSTATE.GOOD;
        player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {

        switch(behaviourState)
        {
            case BEHAVIOURSTATE.GOOD:
                transform.position = this.transform.position;
                break;

            case BEHAVIOURSTATE.EVIL:
                transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
                break;

            default:
                Debug.Log("Your states are broken!");
                break;
        }
	
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}
