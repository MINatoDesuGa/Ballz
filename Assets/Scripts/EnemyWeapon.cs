using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    void Start()
    {
        Shoot();
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        StartCoroutine(ShootDelay(5));
    }
    IEnumerator ShootDelay(float time)
    {
        yield return new WaitForSeconds(time);
        Shoot();
    }
}
