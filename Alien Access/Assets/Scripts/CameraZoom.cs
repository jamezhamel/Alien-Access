using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float minFov;
    public float maxFov;
    public float zoomRate;

    private Camera _cam;

    private void Start ()
    {
        _cam = Camera.main;
    }

    private void Update()
    {
        Zoom();
    }

    private void Zoom()
    {
        if (Input.anyKey)
        {
            float fov = _cam.fieldOfView;

            if (Input.GetKey (KeyCode.UpArrow)) fov -= zoomRate;
            if (Input.GetKey (KeyCode.DownArrow)) fov += zoomRate;

            fov = Mathf.Clamp (fov, minFov, maxFov);
            _cam.fieldOfView = fov;
        }
    }
}
