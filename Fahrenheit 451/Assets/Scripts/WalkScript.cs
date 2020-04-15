using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WalkScript : MonoBehaviour{
    Vector3 targetPosition;
    private Animator anim;
    private Rigidbody rb;
    


    void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
 
    void Update(){
     if (Input.GetMouseButtonDown(0))
     {
        SetTargetPosition();
     }
    
    void SetTargetPosition(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1000)){
            targetPosition = hit.point;
            Debug.Log(targetPosition);
        }
    }

  }

}
