using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthView : MonoBehaviour
{
    public HealthModel model;
    public PlayerHealthController controller;

    public Slider HealthSlider;

    private void OnEnable()
    {
        controller.OnHealthChanged += UpdateHealthBar;
    }

    private void OnDisable()
    {
        controller.OnHealthChanged -= UpdateHealthBar;
    }

    void UpdateHealthBar(int currentHealth)
    {
        
        //HealthSlider.maxValue = maxHealth;

        var normalizedHealth = (float)controller.currentHealth / model.MaxHealth;

        HealthSlider.value = normalizedHealth;
    }

}
