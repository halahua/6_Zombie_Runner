using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSystem : MonoBehaviour
{
    public float lightDecay = .1f;
    public float angleDecay = 1f;
    public float minimumAngle = 40f;

    public Light myLight;

    private void Start() 
    {
        myLight = GetComponent<Light>();   
    }

    private void Update() 
    {
        DecreaseLightAngle();
        DecreaseLightIntensity();
    }

    public void RestoreAngle(float restoreAngle)
    {
        myLight.spotAngle = restoreAngle;
    }

    public void AddLightIntensity(float addLightIntensity)
    {
        myLight.intensity += addLightIntensity;
    }

    private void DecreaseLightAngle()
    {
        if (myLight.spotAngle <= minimumAngle) {
            return;
        } else {
            myLight.spotAngle -= angleDecay * Time.deltaTime;
        }
    }

    private void DecreaseLightIntensity()
    {
        myLight.intensity -= lightDecay * Time.deltaTime;
    }
}
