using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        float positionX = GameObject.FindGameObjectWithTag("Start").transform.position.x;
        float positionY = GameObject.FindGameObjectWithTag("Start").transform.position.y;
        float positionZ = GameObject.FindGameObjectWithTag("Start").transform.position.z;

        
        if (collider.CompareTag("Trap"))
        {
            Debug.Log("TRAPPED !");
            transform.position = new Vector3(positionX, positionX, positionZ);
        }
        else if (collider.CompareTag("Finish"))
        {
            Debug.Log("FINISHED !");
            //transform.position = new Vector3(180, 1.38f, 175);
        }
    }
}

