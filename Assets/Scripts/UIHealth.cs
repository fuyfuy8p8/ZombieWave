using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIHealth : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private TMP_Text _healthText;

    private void Start()
    {
        _health.TakenDamage += SetValue;
    }

    private void SetValue(int value)
    {
        _healthText.text = value.ToString();
    }

    private void OnDisable()
    {
        _health.TakenDamage -= SetValue;
    }
}
