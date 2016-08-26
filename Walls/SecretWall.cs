using UnityEngine;
using System.Collections;

public class SecretWall : MonoBehaviour {
    GameObject player;
    [Header("Appear when this far from player")]
    public float distanceCheck;
    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player");

        // Invisible wall mode!
        this.GetComponent<MeshRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(Vector3.Distance(player.transform.position, this.transform.position) < distanceCheck)
        {
            // Sneaky sneaky appear on you wall!
            this.GetComponent<MeshRenderer>().enabled = true;
        }	    
	}
}
