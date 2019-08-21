using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] float healthPoints = 100f;


    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken"); 
     /* 1. String ref;
        2. Lê todos os scripts DO GAMEOBJ;
        3. Procura todas as funções da string ref;
        4. Chama todas elas ao mesmo tempo;
        Obs.: Se tiver parâmetros, colocar depois da string ref. */
        healthPoints -= damage;

        if(healthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
