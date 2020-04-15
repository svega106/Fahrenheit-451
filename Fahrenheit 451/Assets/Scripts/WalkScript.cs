using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WalkScript : MonoBehaviour{
    Vector3 targetPosition;
    private Animator anim;
    private Transform player;
    [SerializeField]
    private float Speed;
    



    void Start () {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
 
    void Update(){
     if (Input.GetMouseButtonDown(0))
     {
        SetTargetPosition();
     }
    Moveplayer();
    
    void SetTargetPosition(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1000)){
            targetPosition = hit.point;            
        }
    }
    void Moveplayer(){
        
        if (player.position != targetPosition)
        {
            
            float Difx = (targetPosition.x-player.position.x);
           
            float Difz = (targetPosition.z-player.position.z); 
            Vector3 myVector;
            Quaternion myQuaternion;
           
            myVector = new Vector3(player.position.x+(Difx/Speed),0.0f ,player.position.z+(Difz/Speed));
            myQuaternion = new Quaternion(0.0f,0.0f,0.0f,0.0f);
            player.SetPositionAndRotation(myVector , myQuaternion);
            
        }
    }
  }

}
