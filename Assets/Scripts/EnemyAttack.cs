using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    PlayerHealth target;
    public float damage = 40f;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>(); // find object no Start(), mais leve e mais limpo
    }

    public void AttackHitEvent() 
    {
        target.GetComponent<PlayerHealth>().TakeDamage(damage); // assim para referenciar outro script. Variável, GetComponent e depois a função
        /* 
        Poderia ser só assim: 
        target.TakeDamage(damage);
        Pois já está sendo referenciado lá em cima qual o tipo de objeto.
        Vou deixar dessa forma maior pra saber o que fazer quando precisar referenciar localmente.
        */
        if (target == null) { return; }
    }
}
