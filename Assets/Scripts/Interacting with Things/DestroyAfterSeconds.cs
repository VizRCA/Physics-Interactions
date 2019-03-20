using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    public float lifeTime = 10;
    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

}
