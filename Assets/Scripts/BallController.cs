using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    private Rigidbody rig;

    private void Start() {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    private void Update() {
        
    }
}
