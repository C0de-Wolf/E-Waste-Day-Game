using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb; 
	public GameObject Player;
    private Scene scene;
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        rb = gameObject.GetComponent<Rigidbody2D>();
        
        rb.velocity = new Vector2(-10, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player"){
            //Effect ekle
            //Öldür
            SceneManager.LoadScene(scene.name);
			
            Destroy(this.gameObject);
        }else{
            Destroy(this.gameObject);
        }
           
    }
    
}
