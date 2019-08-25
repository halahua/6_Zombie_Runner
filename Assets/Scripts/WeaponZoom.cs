using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{

    [SerializeField] Camera FPCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [Range(1, 100)] [SerializeField] float zoomedOutFOV = 60f;
    [Range(1, 30)][SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomOutMouseSensitivity = 2f;
    [SerializeField] float zoomInMouseSensitivity = .5f;
    //[SerializeField] Vector2 mouseSensitivity = new Vector2(1f, 1f);
    

    bool zommedInToggle = false;


    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zommedInToggle == false)
            {
                //Vector2 newMouseSensitivity = new Vector2(Input.GetAxis("Mouse X") * mouseSensitivity.x,
                //                                          Input.GetAxis("Mouse Y") * mouseSensitivity.y);
                zommedInToggle = true;
                FPCamera.fieldOfView = zoomedInFOV;
                fpsController.mouseLook.XSensitivity = zoomInMouseSensitivity;
                fpsController.mouseLook.YSensitivity = zoomInMouseSensitivity;
            }
            else
            {
                zommedInToggle = false;
                FPCamera.fieldOfView = zoomedOutFOV;
                fpsController.mouseLook.XSensitivity = zoomOutMouseSensitivity;
                fpsController.mouseLook.YSensitivity = zoomOutMouseSensitivity;
            }
        }
    }
}
