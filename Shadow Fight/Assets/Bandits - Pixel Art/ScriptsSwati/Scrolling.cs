using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    private  Transform player; //reference to game object position, rotation
    
    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate() //this will run after update and fixedupdate functiona are compiled
    {
        Vector3 cameraPosition = transform.position; //for current camera position
        cameraPosition.x = player.position.x; //for moving according to player direction direction
        transform.position = cameraPosition; //to update camera position
    }
}
