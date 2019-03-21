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
        // Maybe change the force scaler to a variable?

        rb.useGravity = true;
    }

    private void OnMouseUp()
    {

    }

    private void OnMouseOver()
    {

    }

    private void OnMouseExit()
    {

    }

    private void OnMouseEnter()
    {

    }

    private void OnMouseDrag()
    {

    }

    private void OnMouseDown()
    {

    }
}
