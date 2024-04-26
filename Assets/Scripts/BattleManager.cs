//Zach Rhodes | 4/26/2024 | The Battling!!
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public enum BattleState { Start, PlayerTurn, EnemyTurn, Won, Lost }

public class BattleManager : MonoBehaviour
{
    public TMP_Text dialogueText;
    public GameObject playerPrefab;
    public GameObject enemyPrefab;
    public Transform enemyLocation;
    public GameObject attackButton;
    public GameObject healButton;

    Unit playerUnit;
    Unit enemyUnit;

    public BattleState state;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;
    
    //When scene is loaded, initialize state and start battle!
    void Start()
    {
        state = BattleState.Start;
        StartCoroutine(SetupBattle());
    }

    //Initializing the player and enemy objs, setting dialogue, and setting the HUD. Then setting it to players turn.
    IEnumerator SetupBattle()
    {
        GameObject playerObj = Instantiate(playerPrefab);
        playerUnit = playerObj.GetComponent<Unit>(); 

        GameObject enemyObj = Instantiate(enemyPrefab, enemyLocation);
        enemyUnit = enemyObj.GetComponent<Unit>();

        dialogueText.text = enemyUnit.unitName + " approaches";
       
        playerHUD.SetHUD(playerUnit);
        enemyHUD.SetHUD(enemyUnit);

        yield return new WaitForSeconds(3);
        state = BattleState.PlayerTurn;
        PlayerTurn();
    }

    //Does damage based on players attack value. 
    IEnumerator PlayerAttack()
    {
        attackButton.SetActive(false); healButton.SetActive(false);
        bool isDead = enemyUnit.TakeDamage(playerUnit.damage);

        enemyHUD.SetHP(enemyUnit.currentHP);
        dialogueText.text = "The Attack is successful!";


        yield return new WaitForSeconds(2);

        //If dead, you win!
        if (isDead)
        {
            state = BattleState.Won;
            EndBattle();
        }
        else // else we are not done yet!
        {
            state = BattleState.EnemyTurn;
            StartCoroutine(EnemyTurn());

        }
    }
    //Healing the player based on a static number/ could change later
    IEnumerator PlayerHeal()
    {
        attackButton.SetActive(false); healButton.SetActive(false);
        playerUnit.Heal(10);

        playerHUD.SetHP(playerUnit.currentHP);
        dialogueText.text = "You can feel your strength returning!";

        yield return new WaitForSeconds(2);
        StartCoroutine(EnemyTurn());
    }

    //The enemy will always attack based on its attack value. 
    IEnumerator EnemyTurn()
    {
        dialogueText.text = enemyUnit.unitName + " attacks!";

        yield return new WaitForSeconds(1);

        bool isDead = playerUnit.TakeDamage(enemyUnit.damage);

        playerHUD.SetHP(playerUnit.currentHP);

        yield return new WaitForSeconds(1);

        if(isDead)
        {
            state = BattleState.Lost;
            EndBattle();
        }
        else
        {
            state = BattleState.PlayerTurn;
            PlayerTurn();
        }

    }

    //Battle ending! Either you won or you lost!
    void EndBattle()
    {
        if (state == BattleState.Won)
        {
            dialogueText.text = "You won the battle!";

        }else if (state == BattleState.Lost)
        {
            dialogueText.text = "You were defeated.";
        }
    }
    //Activating UI and allowing for a move to be inputted.
    void PlayerTurn()
    {
        dialogueText.text = "Choose an action: ";
        attackButton.SetActive(true); healButton.SetActive(true);
    }
    //If attack button pressed...start attack
    public void OnAttackButton()
    {
        if (state != BattleState.PlayerTurn)
            return;

        StartCoroutine(PlayerAttack());
    }
    //If heal button pressed...start heal
    public void OnHealButton()
    {
        if (state != BattleState.PlayerTurn)
            return;

        StartCoroutine(PlayerHeal());
    }
}
