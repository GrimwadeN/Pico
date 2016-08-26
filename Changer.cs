using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Changer : MonoBehaviour {

    List<SpriteRenderer> sprites = new List<SpriteRenderer>();
    List<PolygonCollider2D> boxes = new List<PolygonCollider2D>();
    public float transparancy;
    public Color newcolor;
    public Color oldcolor;

	// Use this for initialization
	void Start () {

        foreach (Transform child in transform)
        {
            sprites.Add(child.GetComponent<SpriteRenderer>());
            boxes.Add(child.GetComponent<PolygonCollider2D>());
        }

    }

    // Update is called once per frame
    void Update () {
	
	}

    public void changelight()
    {
      
       for (int i = 0; i < sprites.Count; i++)
        {
            sprites[i].color = newcolor;
            boxes[i].enabled = false;
        }
    }
    public void changedark()
    {
       
        for (int i = 0; i < sprites.Count; i++)
        {
            sprites[i].color = oldcolor;
            boxes[i].enabled = true;
        }
    }
}
