using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDestroy : MonoBehaviour {

    public Transform destroyAction;
    private void OnCollisionEnter(Collision collision)
    {
        // Basic
        Destroy(gameObject);

        // Fun 
        // Instantiate a prefab particle system explosion

        // Bonus
        // Add a explosion sound to particle system
    }
}
