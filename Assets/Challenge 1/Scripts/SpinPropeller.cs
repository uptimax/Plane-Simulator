using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public float propellerSpeed = 981.8f;
    public float angle = 20;
    // Update is called once per frame
    void FixedUpdate()
    {
         transform.Rotate(Vector3.forward, angle * propellerSpeed * Time.deltaTime);
    }
}
