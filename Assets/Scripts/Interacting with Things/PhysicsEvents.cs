using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsEvents : MonoBehaviour {

    public enum State
    {
        Void,
        OnTrigger,
        OnCollision
    }

    public State eventState;

	private void OnTriggerEnter(Collider other)
	{
        eventState = State.OnTrigger;
	}

	private void OnTriggerStay(Collider other)
	{
        eventState = State.OnTrigger;
    }

	private void OnTriggerExit(Collider other)
	{
        eventState = State.Void;
    }

    private void OnCollisionEnter(Collision collision)
    {
        eventState = State.OnCollision;
    }

    
    private void OnCollisionStay(Collision collision)
    {
        eventState = State.OnCollision;
    }

    private void OnCollisionExit(Collision collision)
    {
        eventState = State.Void;
    }

}
