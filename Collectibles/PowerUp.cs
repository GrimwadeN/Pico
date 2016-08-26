using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {
    [Header("Value of pickup")]
    public int PickupValue = 1;
    GameObject boss;
	// Use this for initialization
	void Start () {
        boss = GameObject.FindWithTag("Boss");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            boss.GetComponent<UIDisplay>().points += PickupValue;
            Destroy(this.gameObject);
        }
    }
}
