using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player_Collect : MonoBehaviour
{
    public Text fragmentText;
    private int a = 1;
    void Start()
    {
        fragmentText.text = "0/2 ---";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void OnTriggerEnter2D(Collider2D col)
    {
         if(col.gameObject.tag == "FanFragment"){
                fragmentText.text = $"{a}/2 ---";
                a++;
                Destroy(col.gameObject);
        }
    }
}
