using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DarkWallBehaviour : MonoBehaviour {

    PolygonCollider2D  coll;
    //MeshRenderer mesh;
    // Use this for initialization
    void Start()
    {
        coll = this.GetComponent<PolygonCollider2D>();
       // mesh = this.GetComponent<MeshRenderer>();

        coll.enabled = false;
        //mesh.material.color = new Color(mesh.material.color.r, mesh.material.color.g, mesh.material.color.b, 0);
    }

    // Update is called once per frame
    void Update()
    {

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
        if (coll.enabled == false)
        {
            coll.enabled = true;
           // mesh.material.color = new Color(mesh.material.color.r, mesh.material.color.g, mesh.material.color.b, 1);
        }
        else
        {
            coll.enabled = false;
           // mesh.material.color = new Color(mesh.material.color.r, mesh.material.color.g, mesh.material.color.b, 0.1f);
        }
    }
}
