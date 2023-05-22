using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private int _damage;
    [SerializeField] private float _timeLife;

    private void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
        Destroy(gameObject, _timeLife);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent (out Health enemyHealth))
        {
            enemyHealth.GetDamage(_damage);
        }
    }
}
