using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ResetGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButton("Cancel"))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
	
	}
}
