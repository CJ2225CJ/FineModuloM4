using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] private float rayDistance = 0.1f;
    [SerializeField] private PlayerController _pc;
    [SerializeField] private LayerMask layerGroundMask;
    private void Awake()
    {
        if(_pc == null)
        {
            _pc = GetComponentInParent<PlayerController>();
        }
    }
    private void FixedUpdate()
    {
        CheckGround();
    }
    private void CheckGround()
    {
        bool grounded = Physics.Raycast(transform.position, Vector3.down,rayDistance,layerGroundMask);
        _pc.isGrounded = grounded;
    }
}