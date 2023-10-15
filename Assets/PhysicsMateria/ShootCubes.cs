using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCubes : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            GameObject go = PoolCubes.instance.GetCube();
            go.transform.position = this.transform.position;
            go.transform.rotation = this.transform.rotation;
            go.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 100, ForceMode.Impulse);
        }
    }
}
