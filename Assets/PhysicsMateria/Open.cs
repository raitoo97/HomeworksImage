using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Open : MonoBehaviour
{
  
    private void Update()
    {
        var viejas = Time.time;
        print(viejas);
        if(viejas >= 20)
        {
            Time.timeScale = 0.0f;
        }
    }
}
