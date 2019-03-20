using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerComponentSwitch : MonoBehaviour {
    public enum SwitchType
    {
        DoOnce, DoAllTheTime
    }
    public SwitchType switchType = SwitchType.DoOnce;
    public Behaviour componentToSwitch;
    bool startState, currentState;
    bool allowSwitch = true;
    private void Start()
    {
        startState = currentState = componentToSwitch.enabled;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (switchType == SwitchType.DoOnce && !allowSwitch) return;
        if(collision.transform.tag == "Planet")
        {
            currentState = !currentState;
            componentToSwitch.enabled = currentState;
            allowSwitch = false;
        }
    }
}
