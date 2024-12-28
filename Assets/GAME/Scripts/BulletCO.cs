using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCO : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // E�er �arp�lan nesne Enemy etiketine sahipse, hem d��man� hem mermiyi yok et
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // D��man� yok et
            Destroy(this.gameObject); // Mermiyi yok et
        }
    }
}
