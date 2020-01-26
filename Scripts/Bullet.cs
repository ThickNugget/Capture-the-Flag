using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Destroy(gameObject, 5f);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
     void OnCollisionEnter(Collision collision) {
            if (collision.gameObject.tag == "WALL") {

                print("collidingWithWall");
       		    Destroy(gameObject);

            }
       }  
}