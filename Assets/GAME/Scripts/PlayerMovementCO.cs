using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementCO : MonoBehaviour
{
   private float speed = 5f;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.up * speed * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.A)) // Sol hareket
        {
            transform.Translate(Vector3.left * speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.D)) // Sað hareket
        {
            transform.Translate(Vector3.right * speed * Time.fixedDeltaTime);
        }
    }
}

