using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Dash : MonoBehaviour
{
    
    
    SpriteRenderer m_SpriteRenderer;
    public float CDTime = 2;
    public  float nextUseTime = 0;
    private Rigidbody2D rb2D;
    public float thrust;
    public bool isDashing;
    private Animator anim;
    public ParticleSystem dust;
    public float direction;
    public bool DP;
    public Color firstcolor;
   
   
    void Start()
    {
        
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        
        
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            direction = 1;
        }

        if (Input.GetKey(KeyCode.D)){
            direction = 0;
        }
        if (Time.time > nextUseTime)
        {
            m_SpriteRenderer.color = Color.cyan;
        }
        if (Time.time < nextUseTime)
        {
         
            m_SpriteRenderer.color =  Color.black;
        }




    }
    void FixedUpdate()
    {
        if (Time.time > nextUseTime)
        {
            if (Input.GetKey(KeyCode.LeftShift) && direction ==0)
            {

                rb2D.velocity = new Vector2(thrust * 1, 5);
                Debug.Log("dashing");
                isDashing = true;
              
                CreateDust();
                  StartCoroutine(isDashingz());
                nextUseTime = Time.time + CDTime;   
                CreateDust();
            }
            else
            {
               
            }
            if (Input.GetKey(KeyCode.LeftShift) && direction == 1 
            )
            {

                rb2D.velocity = new Vector2(thrust * -1, 5);
                Debug.Log("dashing");
                 isDashing = true;
                  CreateDust();
                  StartCoroutine(isDashingz());
                nextUseTime = Time.time + CDTime;
                CreateDust();
                
            }
            else
            {
                
            }
            
        }
        

     IEnumerator isDashingz()
    {
        

        yield return new WaitForSeconds(0.4f);
        isDashing = false;
        rb2D.velocity = new Vector2(0, rb2D.velocity.y);
      
        
    }



    }
    void CreateDust()
    {
        dust.Play();
    }
    
    public void direction2()
    {
        direction = 0;
    }

    public void direction0()
    {
        direction = 1;
    }

}