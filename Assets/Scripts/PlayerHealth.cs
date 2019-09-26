using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    [SerializeField] float healthPoints = 100f;


    public void TakeDamage(float damage)
    {
        healthPoints -= damage;
        // GetComponent<DisplayDamage>().ShowDamageImpact(); //MOVED TO: EnemyAttack.cs

        if(healthPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
         /* GetComponent<> é usado quando você quer chamar um script NO MESMO OBJETO
            FindObjectOfType<> é usado quando você quer procurar um script NA CENA INTEIRA
            Não é aconselhável a usar o FindObjOfType porque ele é muito lento.
            Tente usar GetComponentInChildren ou tags, caso seja possível. */
        }
    }
}
