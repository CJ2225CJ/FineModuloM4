using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    [SerializeField] float sens = 10f;
    float roteation;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Mouse X") * sens;
        float y = Input.GetAxisRaw("Mouse Y") * sens;
        roteation -= y;
        roteation = Mathf.Clamp(roteation, -90, 90);
        transform.localRotation = Quaternion.Euler(roteation, 0, 0);
        player.Rotate(Vector3.up * x);
    }
}
