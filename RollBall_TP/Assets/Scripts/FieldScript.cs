using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldScript : MonoBehaviour
{
    private float rotationSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        //Debug.Log( "horizontal = " + horizontal);
        float vertical = Input.GetAxis("Vertical");
        //Debug.Log("Vertical = " + vertical);

        transform.Rotate(new Vector3(vertical, 0, - horizontal) * Time.deltaTime * rotationSpeed);
    }
}
