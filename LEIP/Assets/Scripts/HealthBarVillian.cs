using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarVillian : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    private float MaxHealth = 100f;
    CombatEnController Villian;

    private void Start()
    {

        HealthBar = GetComponent<Image>();
        Villian = FindObjectOfType<CombatEnController>();
    }

    private void Update()
    {
        CurrentHealth = Villian.Health;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
    }
}
