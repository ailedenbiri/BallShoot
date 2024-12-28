using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAM : MonoBehaviour
{

    [SerializeField] private Transform player;  
    [SerializeField] private float yOffset = 5f; 

    private void LateUpdate()
    {
        
        transform.position = new Vector3(transform.position.x, player.position.y + yOffset, transform.position.z);
    }
}

