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
        rb.AddForce(-transform.forward * 1500f,ForceMode.Impulse);
        rb.useGravity = true;
    }


}
