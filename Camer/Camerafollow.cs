using UnityEngine;
using System.Collections;

public class Camerafollow : MonoBehaviour {

    public GameObject target;
    public float xoffset;
    private Vector3 newpos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        newpos = transform.position;
        newpos.x = target.transform.position.x + xoffset;
        transform.position = newpos;
	
	}
}
