using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
	public Player_Collect playerCollect;
	public Sprite closedSprite;
	public Sprite openSprite;
	private bool open = false;

    // Start is called before the first frame update
    void Start()
    {
		gameObject.GetComponent<SpriteRenderer>().sprite = closedSprite;
    }

    // Update is called once per frame
    void Update()
    {
		if (open) return;

        if (playerCollect.a == 2) {
			open = true;
			gameObject.GetComponent<SpriteRenderer>().sprite = openSprite;
		}
    }
}
