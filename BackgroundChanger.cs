using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BackgroundChanger : MonoBehaviour {

	public Texture lightBackground;
	public Texture darkBackground;

	MeshRenderer rend;

	// Use this for initialization
	void Start () {
		
		rend = GetComponent<MeshRenderer> ();
		rend.material.mainTexture = darkBackground;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Jump")) {
			if (rend.material.mainTexture == darkBackground) {
				rend.material.mainTexture = lightBackground;
			} else if (rend.material.mainTexture == lightBackground) {
				rend.material.mainTexture = darkBackground;
			}
		}

	}
}
