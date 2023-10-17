using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSky : MonoBehaviour
{
    public Material Sky;
    void Start()
    {
        RenderSettings.skybox = Sky;
    }
}
