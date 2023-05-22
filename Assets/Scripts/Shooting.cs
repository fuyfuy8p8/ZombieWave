using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting: MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private float fireTime;
    [SerializeField] private Transform _camera; 
    private Coroutine _coroutine;

    private void OnEnable()
    {
        _coroutine = StartCoroutine(Timer());
    }

    private void OnDisable()
    {
        StopCoroutine(_coroutine);
    }

    private IEnumerator Timer()
    {
        while (true)
        {
            CreateBullet();

            yield return new WaitForSeconds(fireTime);
        }
    }

    private void CreateBullet()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, _camera.rotation);
        }
    }
}
