using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WalkScript : MonoBehaviour{
    private Animator anim;
    private Rigidbody rb;
    [SerializeField]
    private float Speed;



    void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
 
    void Update(){
        
        if (Input.GetButton("Horizontal")){
            transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*Speed, 0, 0);    
        }
        if (Input.GetButton("Vertical")){
            transform.Translate(0, 0, Input.GetAxis("Vertical")*Time.deltaTime*Speed);
        }
    }
    

}
