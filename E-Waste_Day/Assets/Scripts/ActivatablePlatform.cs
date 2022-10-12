using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatablePlatform : MonoBehaviour
{
    // Start is called before the first frame update
	public MovingPlatform mov;
	public GameObject Player;
	private bool move = false;

    void Start()
    {
		mov.move = false;
    }

	private void OnCollisionEnter2D(Collision2D col) {
		if (move) return;
		
		if (col.gameObject == Player) {
			mov.Start();
			move = true;
			mov.move = true;
		}
	}
}
