using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private TMP_Text _healthText;

    public void GetDamage(float damage)
    {
        _health -= damage;

        if (_health<=0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    public void ChangeHealth()
    {
        _healthText.text = _health.ToString();
    }
}
