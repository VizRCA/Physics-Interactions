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
        hit.rigidbody.isKinematic = false;
        hit.rigidbody.AddForce(-hit.normal * hitForce, ForceMode.Impulse);
        hit.rigidbody.AddTorque(-Vector3.Cross(hit.point - rayOrigin, hit.normal) * hitForce);
        hit.rigidbody.useGravity = true;
    }
}
