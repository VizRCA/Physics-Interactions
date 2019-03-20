using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverPad : MonoBehaviour {

    public float hoverForce;


    void OnTriggerStay(Collider other)
    {
        // If the other collider is the player, add a force to its rigid body
        // You will need this: AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
    }
}
