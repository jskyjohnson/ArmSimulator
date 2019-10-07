using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor1Controller : MonoBehaviour {
    public KeyCode moveUpKey, moveDownKey;
    public float armSpeed;
    public bool moving;
    public bool atposition;
    public float toangle;
    void Update () {
        if (Input.GetKey (moveUpKey)) {
            this.transform.Rotate (new Vector3 (0.0f, 0.0f, -armSpeed * Time.deltaTime));
        }

        if (Input.GetKey (moveDownKey)) {
            this.transform.Rotate (new Vector3 (0.0f, 0.0f, armSpeed * Time.deltaTime));
            // //move paddle down
            // Vector3 currPos = transform.position;
            // Vector3 newPos = new Vector3(currPos.x, currPos.y - armSpeed * Time.deltaTime, currPos.z);
            // transform.position = newPos;
        }
        if (moving) {
            if (this.transform.rotation.eulerAngles.z > toangle) {
                this.transform.Rotate (new Vector3 (0.0f, 0.0f, armSpeed * Time.deltaTime));
            } else if (this.transform.rotation.eulerAngles.z < toangle) {
                this.transform.Rotate (new Vector3 (0.0f, 0.0f, -armSpeed * Time.deltaTime));
            } else {
                Debug.Log ("THERE!");
                atposition = true;
                moving = false;
            }
        }
    }
    public void MoveRequest (float angle) {
        if (moving) {
            Debug.Log ("Moving already!");
        } else {
            atposition = false;
            moving = true;
            toangle = angle;
        }
    }

    public void Rotate(float q){
        this.transform.Eu( new Vector3( 0.0f, 0.0f, q ));
    }

}