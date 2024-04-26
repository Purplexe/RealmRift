//Zach Rhodes | 4/26/2024 | Battle Hud Init
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text levelText;
    public Slider hpSlider;

    //Setting up each respective HUD
    public void SetHUD(Unit unit)
    {
        nameText.text = unit.unitName;
        levelText.text = "Lvl " + unit.unitLevel;
        hpSlider.maxValue = unit.maxHP;
        hpSlider.value = unit.currentHP;
        Debug.Log("Set up " + unit.unitName);

    }
    //Setting the HP/ more efficient than setting every attribute each time
    public void SetHP(int hp)
    {
        hpSlider.value = hp;
    }

}
