using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerCO : MonoBehaviour
{
    private Renderer gateRenderer;
    private Renderer playerRenderer;

    private void Awake()
    {
        playerRenderer = GetComponent<Renderer>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Renderer gateRenderer = other.gameObject.GetComponent<Renderer>();
           
            if (gateRenderer != null)
            {         
                playerRenderer.material.color = gateRenderer.material.color;
            }
        }
        
       
    }
}
