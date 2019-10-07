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
        for(int i = 0; i < MAXVAL; i++){
            lr.SetPosition(i, this.transform.position);
        }
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
