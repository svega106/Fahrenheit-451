using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour
{
    private float speed = 5f;
    public Rigidbody rb;

public class WalkScript : MonoBehaviour{
    private Animator anim;
    private Rigidbody rb;
    [SerializeField]
    private float Speed;
    private float idleH;
    private float idleV;

    void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
 
    void Update(){
        anim.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
        if (Input.GetButton("Horizontal")){
            transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*Speed, 0, 0);
            idleH = Input.GetAxisRaw("Horizontal");
            anim.SetBool("isWalk", true);   
        }
        if (Input.GetButton("Vertical")){
            transform.Translate(0, 0, Input.GetAxis("Vertical")*Time.deltaTime*Speed);
            idleV = Input.GetAxisRaw("Vertical");
            anim.SetBool("isWalk", true);    
        }
        else{
            anim.SetFloat("IdleH",idleH);
            anim.SetFloat("IdleV",idleV);
            anim.SetBool("isWalk", false);
        }
    }

}
