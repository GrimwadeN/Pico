using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShieldCollection : MonoBehaviour {

    
    GameObject player;
    GameObject boss;

    float timer;
    int pieces;
    [Header("Shield variables")]
    int requiredPieces = 4;
    public float maxShieldTime = 3;
    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player");
        boss = GameObject.FindWithTag("Boss");
 
    }
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
        if(boss.GetComponent<UIDisplay>().collectedPieces == requiredPieces)
        {
			timer = 0;
            player.GetComponent<PlayerState>().playerState = PLAYERSTATE.SHIELDED;
			boss.GetComponent<UIDisplay> ().collectedPieces = 0;
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            boss.GetComponent<UIDisplay>().collectedPieces += 1;           
            Destroy(this.gameObject);
        }
    }
}
