using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighJump : MonoBehaviour
{
    public Movement movescr;
    Rigidbody2D rb;
    public ParticleSystem jdust;
    public float CDTime = 2;
    public  float nextUseTime = 0;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     if (Time.time > nextUseTime){
        if(Input.GetKeyDown(KeyCode.Q)){
            rb.AddForce(new Vector2(0, 10), ForceMode2D.Impulse); 
            StartCoroutine(Wait()); 
            nextUseTime = Time.time + CDTime;   
            DustCreate();
        }
    }
    }
    IEnumerator Wait()
    {
        

        yield return new WaitForSeconds(0.4f);
       
        
      
        
    }
    void DustCreate()
    {
        Debug.Log("kek");
        jdust.Play();
    }
    
}
