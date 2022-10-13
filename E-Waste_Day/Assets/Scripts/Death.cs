using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
	private Scene scene;
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void respawn(bool reloadScene=true) {
		if (reloadScene) {
			SceneManager.LoadScene(scene.name);
		}
	}

	private void OnCollisionEnter2D(Collision2D col) {
		if (col.collider.tag == "Fatal") {
			Debug.Log("Reloaded scene");
			respawn();
		}
	}
}
