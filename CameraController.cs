using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private Camera FPSCamera;

    private bool mainCameraON = true;

    void Start()
    {
        mainCamera.enabled = true;
        FPSCamera.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && mainCameraON == true)
        {
            mainCamera.enabled = false;
            FPSCamera.enabled = true;

            mainCameraON = false;
        }
        else if (Input.GetKeyDown(KeyCode.C) && mainCameraON == false)
        {
            mainCamera.enabled = true;
            FPSCamera.enabled = false;

            mainCameraON = true;
        }
    }
}
