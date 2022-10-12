using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // Start is called before the first frame update
	private const float fTime = 0.5f;
	private const float fDist = 4.0f;
	public GameObject Player;

	private float origX;
    void Start()
    {
        origX = gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Mathf.Abs(((fTime * Time.time) % 2.0f) - 1.0f) - 0.5f;
		gameObject.transform.position = new Vector3(origX + fDist * delta, gameObject.transform.position.y, gameObject.transform.position.z);
    }

	private void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject == Player) {
			col.collider.transform.SetParent(transform);
		}
	}

	private void OnCollisionExit2D(Collision2D col) {
		if (col.gameObject == Player) {
			col.collider.transform.SetParent(null);
		}
	}
}
