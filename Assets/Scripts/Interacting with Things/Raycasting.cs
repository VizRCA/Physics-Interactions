using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour {
    [Range(0.0f, 0.5f)]
    public float RayRadius;
    private readonly Vector3 _viewPos = new Vector3(0.5f, 0.5f);
    private Camera fpsCam;

    [Range(0, 5000)]
    public float hitForce = 100f;


    void Start()
    {
        fpsCam = GetComponentInParent<Camera>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // TODO 1. Get ray from camera viewport given screen centre point
            // Camera.ViewportToWorldPoint

            // TODO 2. Determine distance based on camera clip planes

            // TODO 3. Do a sphere cast or raycast 
            // Physics.SphereCast(args) or Physics.Raycast


            // TODO 4. If cast hits something with a rigid body, apply phyiscs forces
            // rigidbody.AddForce(-hit.normal * hitForce, ForceMode.Impulse);
            // rigidbody.AddTorque(-Vector3.Cross(hit.point - rayOrigin, hit.normal) * hitForce);

            // TODO 5. Improve this method, see if the hit thing has a HitEvent component and do physics there.

        }
    }
}
