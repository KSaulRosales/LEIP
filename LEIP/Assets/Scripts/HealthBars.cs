using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBars : MonoBehaviour
{
    [SerializeField] private Image healthImage;

    public void UpdateHealthBarAmount (float percentHealth)
    {
        this.healthImage.fillAmount = percentHealth;
    }
}
