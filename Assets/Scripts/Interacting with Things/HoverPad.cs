using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverPad : MonoBehaviour {

    public float hoverForce;


    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
            other.GetComponent<Rigidbody>().AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
    }
}
