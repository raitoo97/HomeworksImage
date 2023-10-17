using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Op : MonoBehaviour
{
    public bool isopen;
    public float open_degrees;
    public float close_degrees;
    public float smooth;
    private void Start()
    {
        open_degrees = 90.0f;
        close_degrees = 0.0f;
        smooth = 3.0f;
    }
    private void Update()
    {
        if (isopen)
        {
            var rot_open = Quaternion.Euler(0.0f, open_degrees,0.0f );
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, rot_open, smooth * Time.deltaTime);
        }
        else
        {
            var close_rot = Quaternion.Euler(0.0f, close_degrees, 0.0f);
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, close_rot, smooth * Time.deltaTime);
        }
    }
}
