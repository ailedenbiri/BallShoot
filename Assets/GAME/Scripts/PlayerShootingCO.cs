using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingCO : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPoint;
    bool isShootingOn;

    private void Awake()
    {
        isShootingOn = false;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !isShootingOn)
        {
            isShootingOn = true;
            StartCoroutine(SpawnBullets());
        }


        if (Input.GetKeyUp(KeyCode.Space))
        {
            isShootingOn = false;
        }
    }

    private void CreateBullet()
    {
        GameObject bulletGO = Instantiate(bullet, bulletPoint.position, Quaternion.identity);
        Rigidbody bulletRb = bulletGO.GetComponent<Rigidbody>();
        bulletRb.velocity = Vector3.up * 15;

        Destroy(bulletGO, 2f);
    }

    IEnumerator SpawnBullets()
    {
        while (isShootingOn)
        {
            CreateBullet();
            yield return new WaitForSeconds(.5f);
        }
    }

}
