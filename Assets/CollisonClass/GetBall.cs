using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBall : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = PoolController.instance.GetBall();
            go.transform.position = this.transform.position;
            go.transform.rotation = this.transform.rotation;
        }
    }
}
