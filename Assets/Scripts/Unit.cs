//Zach Rhodes | 4/26/2024 | Unit Stats
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;
    public int unitLevel;
    public int damage;
    public int maxHP;
    public int currentHP;

    //Method to Do damage to unit
    public bool TakeDamage(int dmg)
    {
        currentHP -= dmg;

        if (currentHP <= 0)
            return true;
        else 
            return false;
    }

    //Method to heal damage
    public void Heal(int amount)
    {
        currentHP += amount;
        if (currentHP <= maxHP)
            currentHP = maxHP;
    }

}
