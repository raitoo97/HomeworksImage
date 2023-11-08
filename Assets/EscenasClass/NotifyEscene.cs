using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotifyEscene : MonoBehaviour
{
    public Transform Ref_Distance;
    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void Update()
    {
        print(Vector3.Distance(this.transform.position, Ref_Distance.position));
        if (Vector3.Distance(this.transform.position, Ref_Distance.position) < 5.0f)
        {
            EscenemMannager.instance.OpenAsyncSceneAditive("Escena3");
        }
    }
}
