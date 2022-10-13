using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject bulletpref;
    float nextShot;
    public float shotCD;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextShot){ 


            Instantiate(bulletpref, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);


            nextShot = Time.time + shotCD;
        }
    }
}
