using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public static int numOfBulletsFired;
    // Start is called before the first frame update
    void Start()
    {
        numOfBulletsFired = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBullet();
            numOfBulletsFired++;
            BulletCounter.Bullets--;
            BulletCounter.temp++;
        }
    }
    public void ShootBullet()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
