using UnityEngine;
using System.Collections;

public class Background_Scroll : MonoBehaviour {

	[Header("Background Scroll options")]
	public float scrollSpeed = 0.1f;

	Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();  
	}
	
	// Update is called once per frame
	void Update () {

		float offset = Time.time * scrollSpeed;
		rend.material.SetTextureOffset ("_MainTex", new Vector2(offset, 0));
        //rend.material.SetTextureOffset("_SecondTex", new Vector2(offset, 0));
	
	}
}
