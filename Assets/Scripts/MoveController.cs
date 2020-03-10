using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {

    private Rigidbody rigidbody;
    private float moveSpeed = 5;

    void Start () {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update () {

        Vector3 primaryTouchPad = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);

        // 上はz+、下はz-、右はx+、左はx-
        Vector3 position = new Vector3(primaryTouchPad.x, 0, primaryTouchPad.y);

        rigidbody.velocity = position * moveSpeed;
    }
}
