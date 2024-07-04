using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HealthModel", menuName = "Scriptable Objects/HealthModel")]
public class HealthModel : ScriptableObject
{
    public int InitialHealth;
    public int MaxHealth;
    public int MinHealth;
}
