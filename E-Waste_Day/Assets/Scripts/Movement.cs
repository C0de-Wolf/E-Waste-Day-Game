using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
	    public float speed;
		
        public float jumpForce;
        private float moveInput;
		public bool isGrounded;
        private Rigidbody2D rb;
        
		public Transform groundcheck;
		public float checkRadius;
		public LayerMask WhatisGround;
		
		public Dash dashs;  
	
	
	
		


        void Start(){
            rb = GetComponent<Rigidbody2D>();
			
        }
		void FixedUpdate() {
			isGrounded = Physics2D.OverlapCircle(groundcheck.position, checkRadius, WhatisGround); 
			
			moveInput = Input.GetAxis("Horizontal");
			if ( dashs.isDashing == false){
           			rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
                    
        	}
		
			
		}
		void Update(){
				
        
			if(isGrounded){
				rb.gravityScale = 2;
				if(Input.GetKeyDown(KeyCode.Space)){
					rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse); 

				}
				
			}
		
		
		}
    

	
	
	
	
		

	
	}
