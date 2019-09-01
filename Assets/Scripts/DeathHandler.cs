using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{

    [SerializeField] Canvas gameOverCanvas;
    WeaponSwitcher weaponSwitcher;


    private void Start()
    {
        gameOverCanvas.enabled = false;
        weaponSwitcher = GetComponentInChildren<WeaponSwitcher>();
    }

    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
        //FindObjectOfType<WeaponSwitcher>().enabled = false;
        weaponSwitcher.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
