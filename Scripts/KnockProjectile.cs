﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockProjectile : MonoBehaviour
{

    
    public float speed = 2f;
    public float impulseforce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "player")
            {
                collision.gameObject.GetComponent<Rigidbody>().AddForce(
                    transform.forward * impulseforce, ForceMode.Impulse);
                Destroy(gameObject);
            }
        }
    }
}
