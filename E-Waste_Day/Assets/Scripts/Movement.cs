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

		private bool jumpBoostAvailable;
		
		public Dash dashs;  
	
	
	
		


        void Start(){
            rb = GetComponent<Rigidbody2D>();
			jumpBoostAvailable = false;
			
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
					if (jumpBoostAvailable) {
						rb.AddForce(new Vector2(0, jumpForce*1.3f), ForceMode2D.Impulse); 
					} else {
						rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse); 
					}

				}
				
			}
		
		
		}

		void OnCollisionEnter2D(Collision2D col) {
			if (col.collider.tag == "JumpBoostPlat") {
				jumpBoostAvailable = true;
			}
		}
		void OnCollisionExit2D(Collision2D col) {
			if (col.collider.tag == "JumpBoostPlat") {
				jumpBoostAvailable = false;
			}
		}
    

	
	
	
	
		

	
	}
