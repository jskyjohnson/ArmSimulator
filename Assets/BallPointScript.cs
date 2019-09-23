using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPointScript : MonoBehaviour
{
    public int MAXVAL;
    private LineRenderer lr;
    private int index;

    void Start(){
        lr = GetComponent<LineRenderer>();
        index = 0;
    }
    
    void Update(){
        
        lr.SetPosition(index, this.transform.position);
        index++;
        if(index >= MAXVAL){
            index = 0;
        }
    }

}
