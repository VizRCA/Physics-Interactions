using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour {
    [Range(0.0f, 0.5f)]
    public float RayRadius;
    private readonly Vector3 _viewPos = new Vector3(0.5f, 0.5f);
    private Camera fpsCam;

    [Range(0,5000)]
    public float hitForce = 100f;


    void Start()
    {
        fpsCam = GetComponentInParent<Camera>();
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(_viewPos);

            float distance = fpsCam.farClipPlane - fpsCam.nearClipPlane;

            RaycastHit hit;

            if (Physics.SphereCast(rayOrigin,RayRadius, fpsCam.transform.forward, out hit, distance))
            {
                if(hit.transform.GetComponent<HitEvent>()){
                    hit.transform.GetComponent<HitEvent>().Hit(rayOrigin, hit, hitForce);
                }
                else{
                    if (hit.rigidbody != null)
                    {
                        hit.rigidbody.isKinematic = false;
                        hit.rigidbody.AddForce(-hit.normal * hitForce, ForceMode.Impulse);
                        hit.rigidbody.AddTorque(-Vector3.Cross(hit.point - rayOrigin, hit.normal) * hitForce);
                        hit.rigidbody.useGravity = true;
                    }    
                }

            }

        }
    }
}
