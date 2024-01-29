using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStatsObject : ScriptableObject
{
    [Header("General")]    
    [SerializeField] private string m_name;

    [Header("Attributes")]
    [SerializeField] private int m_meleeDamage;
    [SerializeField] private int m_meleeSpeed;

    [SerializeField] private int m_thrownDamage;
    [SerializeField] private int m_thrownSpeed;
    [SerializeField] private int m_carryCapacity;
    [SerializeField] private int m_moveSpeed;
    [SerializeField] private float m_sprintModifier;
    [SerializeField] private float m_sneakModifier;
    [SerializeField] private float m_noiseReduction;
    [SerializeField] private float m_evasionRate;

    #region Accessors
    public string Name { get { return m_name; } }
    public int MeleeDamage { get { return m_meleeDamage; } }
    public int MeleeSpeed { get { return m_meleeSpeed; } }


    #endregion


    public void SetName(string name) {
        m_name = name;
    }
    
}
