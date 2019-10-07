using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmController : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject toobject;
    public GameObject arm1;
    public GameObject arm2;
    public GameObject Motor1;
    public GameObject Motor2;
    private Motor1Controller mone;
    private Motor1Controller mtwo;

    private float s1; //arm1 size
    private float s2; //arm2 size

    void Start () {
        mone = Motor1.GetComponent<Motor1Controller> ();
        mtwo = Motor2.GetComponent<Motor1Controller> ();
        s1 = arm1.transform.localScale.x;
        s2 = arm2.transform.localScale.x;
        mone.MoveRequest (0);
        mtwo.MoveRequest (0);
    }

    // Update is called once per frame
    void Update () {
        //mone.MoveRequest();
        float x = toobject.transform.position.x; 
        float y = toobject.transform.position.y;
        float q2 = Mathf.Acos(( x*x + y*y -s1*s1 - s2*s2 )/(2*s1*s2) ); 
        float q1 = Mathf.Atan(y/x) - Mathf.Atan( (s2*Mathf.Sin(q2))/(s1+s2*Mathf.Cos(q2)) );

        SetPositionInverseKin(q1, q2); 
    }

    void SetPositionInverseKin(float q1, float q2){

        mone.Rotate(q1);
        mtwo.Rotate(q2);
        //mone.MoveRequest(q1);
        //mtwo.MoveRequest(q2);
    }
}