using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour {

    [Header("Dont touch")]
    public Text shieldText;
    public Text score;
    public int requiredPieces = 4;
    public int collectedPieces;

    public int points = 0;
    

    GameObject UI;

    // Use this for initialization
    void Start () {
        score = GetComponent<Text>(); 
    }
	
	// Update is called once per frame
	void Update () {

        //shieldText.text = "Shield pieces collected: " + collectedPieces + "/" + requiredPieces;
        //score.text = "Score: " + points;
    }
}
