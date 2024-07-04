using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem_Template : MonoBehaviour
{

    ///////////////////////// Public Variables ////////////////////////////
    
    //public StateMachine PlayerStateMachine;
    //public State Idle;
    //public State Dead;
    
    [Range(0,100)]
    public int CurrentHealth;
    public int MaxHealth = 100;
    public int MinHealth = 0;
    
    public Slider HPSlider;
    
    ///////////////////////// Private Variables //////////////////////////
    
    ///////////////////////// Unity Methods /////////////////////////////
    
    void Start()
    {

    }

    private void Update()
    {
        UpdateUI();
    }

    ///////////////////////// Control Methods //////////////////////////
    
    public void Damage(int damage)
    {
        CurrentHealth -= damage;
        UpdateUI();
    }

    public void Heal(int heal)
    {
        CurrentHealth += heal;
        UpdateUI();
    }

    public void Die()
    {
        if (CurrentHealth <= MinHealth)
        {
            Destroy(gameObject);
            //PlayerStateMachine.ChangeState(Dead);
        }
    }
    
    ///////////////////////// Visualization Methods /////////////////////
    
    public void UpdateUI()
    {
        var normalizedHealth = (float)CurrentHealth / MaxHealth;

        HPSlider.value = normalizedHealth;

        Debug.Log("Current Health: " + CurrentHealth);
    }
    
    

}