using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAngles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            transform.Translate(Vector3.back * 200 * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            transform.Translate(Vector3.forward * 200 * Time.deltaTime);
        }

 		if (Input.GetKeyDown(KeyCode.O))
        {
            transform.Translate(Vector3.forward * 200 * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            transform.Translate(Vector3.back * 200 * Time.deltaTime);
        }




    }
}
