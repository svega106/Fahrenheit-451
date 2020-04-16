using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour {
 
    public Transform player;
    public float panSpeed;
    public float height;
    public float distance;

    
    void Update () {
        var newPosition = new Vector3(player.position.x, player.position.y + height, player.position.z - distance);
        transform.position = Vector3.Lerp(transform.position, newPosition, panSpeed * Time.deltaTime);
    }
}
