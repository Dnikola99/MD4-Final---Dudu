using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public HealthModel model;

    public int currentHealth;


    // For broadcasting health updates.
    public event System.Action<int> OnHealthChanged;

    void Start()
    {
        currentHealth = model.InitialHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int damage)
    {
        currentHealth -= damage;
        
        //Clamp current health to min and max values
        currentHealth = Mathf.Clamp(currentHealth, model.MinHealth, model.MaxHealth);
        OnHealthChanged?.Invoke(currentHealth);
    }

   public void Heal(int amount)
    {
        currentHealth += amount;
        
        //Clamp current health to min and max values
        currentHealth = Mathf.Clamp(currentHealth, model.MinHealth, model.MaxHealth);
        OnHealthChanged?.Invoke(currentHealth);
    }

    public void ResetHealth()
    {
        currentHealth = model.InitialHealth;
        OnHealthChanged?.Invoke(model.InitialHealth);
    }

}
