using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallkAttachted : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>())
        {
            collision.gameObject.AddComponent<FixedJoint>();
            var Fixed = collision.gameObject.GetComponent<FixedJoint>();
            if (collision.gameObject.GetComponent<FixedJoint>())
            {
                Fixed.connectedBody = this.GetComponent<Rigidbody>();
            }
        }
    }
}
