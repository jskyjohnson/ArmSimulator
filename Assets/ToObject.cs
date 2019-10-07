using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToObject : MonoBehaviour {
    //Just a floating thing
    private float time;
    public float scale;

    public float a;
    public float cof1;
    public float offset1;
    public float b;
    public float cof2;
    public float offset2;
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        time = Time.time * scale;
        this.transform.position = new Vector3 (cof1 * Mathf.Sin (a * (time)) + offset1, cof2 * Mathf.Cos (b * time) + offset2, 0.0f);
    }
}