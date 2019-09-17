using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    public float restoreAngle = 90f;
    public float addLightIntensity = 1f;
    
    
    private void OnTriggerEnter(Collider collider) 
    {
        /* No OnTriggerEnter, para chamar outro script, você vai usar o collider (vai vir como "other"),
           e vai linkar ele direto com o GetComponent.
           Lembrando que esse GetComponentInChildren tá falando do objeto que o BatteryPickup tá procurando.
           No caso, o FlashLightSystem é FILHO do PLAYER.
           O BatteryPickup vai procurar NO PLAYER, e não nele mesmo.
           Isso é importante para poder usar o GetComponent na maioria dos casos. */
        collider.GetComponentInChildren<FlashLightSystem>().RestoreAngle(restoreAngle);
        collider.GetComponentInChildren<FlashLightSystem>().AddLightIntensity(addLightIntensity);
        Destroy(gameObject);
    }
}
