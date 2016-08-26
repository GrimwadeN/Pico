using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WallBehaviour : MonoBehaviour {

    CapsuleCollider coll;
    MeshRenderer mesh;
    // Use this for initialization
    void Start() {
        coll = this.GetComponent<CapsuleCollider>();
        mesh = this.GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
        
    }

    public void SwapState()
    {
        //if(coll.enabled == false)
        //{
        //    coll.enabled = true;
        //    this.mesh.material.color = new Color(this.mesh.material.color.r, this.mesh.material.color.g, this.mesh.material.color.b, 1);
        //}
        //else
        //{
        //    coll.enabled = false;
        //    this.mesh.material.color = new Color(this.mesh.material.color.r, this.mesh.material.color.g, this.mesh.material.color.b, 0.1f);
        //}
    }
}
