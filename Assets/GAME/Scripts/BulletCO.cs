using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCO : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Eðer çarpýlan nesne Enemy etiketine sahipse, hem düþmaný hem mermiyi yok et
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // Düþmaný yok et
            Destroy(this.gameObject); // Mermiyi yok et
        }
    }
}
