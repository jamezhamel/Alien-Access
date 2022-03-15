using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    void Start()
    {
        SetCameraPosition();
    }

    private void SetCameraPosition()
    {
        var focusPosition = target.position;
        this.transform.position = focusPosition + offset;
        this.transform.LookAt(focusPosition);
    }

    private void LateUpdate()
    {
        this.transform.position = target.position + offset;
    }
}
