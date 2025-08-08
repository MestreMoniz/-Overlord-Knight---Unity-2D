using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void AddSpeed(float speed)
    {
        PlayerMovement playerMovement = GetComponent<PlayerMovement>();
        playerMovement.moveSpeed = playerMovement.moveSpeed + speed;
    }
    public void AddHealth(int health)
    {
        PlayerHealth playerHealth = GetComponent<PlayerHealth>();
        playerHealth.addHHealth(health);
    }

    public void AddAttack(int attack)
    {
        PlayerCombat playerCombat = GetComponent<PlayerCombat>();
        playerCombat.attackDamage = playerCombat.attackDamage + attack;
    }

    public void AddAttackSpeed(float AttackSpeed)
    {
        PlayerCombat playerCombat = GetComponent<PlayerCombat>();
        playerCombat.attackRate = playerCombat.attackRate + AttackSpeed;
        Shooting shooting = GetComponent<Shooting>();
        shooting.attackRate = shooting.attackRate + AttackSpeed;


    }


}

