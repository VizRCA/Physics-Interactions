using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseDown : MonoBehaviour {
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseUpAsButton()
    {
        rb.isKinematic = false;
        // TODO Add force to rigid body
        // AddForce(direction, ForceMode.Impulse);
        Vector3 forceDirection = -transform.forward * 1500f;

        rb.useGravity = true;
    }
}
