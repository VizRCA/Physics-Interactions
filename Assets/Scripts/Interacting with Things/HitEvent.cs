using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEvent : MonoBehaviour {
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Hit(Vector3 rayOrigin, RaycastHit hit, float hitForce)
    {
        // TODO Do physics forces here
    }
}
