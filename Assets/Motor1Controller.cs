using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor1Controller : MonoBehaviour
{
    public KeyCode moveUpKey, moveDownKey;
    public float armSpeed;
    void Update()
    {
        if (Input.GetKey(moveUpKey))
        {
            this.transform.Rotate(new Vector3(0.0f, 0.0f, -armSpeed*Time.deltaTime));
        }
        
        if (Input.GetKey(moveDownKey))
        {
            this.transform.Rotate(new Vector3(0.0f, 0.0f, armSpeed*Time.deltaTime));
            // //move paddle down
            // Vector3 currPos = transform.position;
            // Vector3 newPos = new Vector3(currPos.x, currPos.y - armSpeed * Time.deltaTime, currPos.z);
            // transform.position = newPos;
        }
    }
}


