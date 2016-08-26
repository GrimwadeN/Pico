using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class SpriteChanger : MonoBehaviour {

    public Renderer ren;
    public Material lightmaterial;
    public Material darkmaterial;

	// Use this for initialization
	void Start () {
        ren = GetComponent<Renderer>();
        //foreach (Transform child in transform)
        //{
        //    sprites.Add(child.GetComponent<Material>());
        //}
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

    public void changelight()
    {
        ren.material = lightmaterial;
        //for (int i = 0; i < sprites.Count; i++)
        //{
        //    sprites[i].SetTexture  = lightmaterial;
        //}
    }
    public void changedark()
    {
        ren.material = darkmaterial;
        //for (int i = 0; i < sprites.Count; i++)
        //{
        //    sprites[i].sprite = darkmaterial;
        //}
    }
}
