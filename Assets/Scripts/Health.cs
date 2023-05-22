using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private TMP_Text _healthText;

    public event Action<int> TakenDamage;
    public void GetDamage(int damage)
    {
        _health -= damage;
        TakenDamage?.Invoke(_health);

        if (_health<=0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
