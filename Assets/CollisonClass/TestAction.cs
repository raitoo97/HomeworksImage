using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestAction : MonoBehaviour
{
    public List <Force> cubos;
    void Start()
    {
        cubos = new List <Force>(GameObject.FindObjectsOfType<Force>());
        foreach (Force force in cubos)
        {
            force.forceAction += Reloco;
        }
    }
    private void Reloco(List<GameObject> list)
    {
        var go = list.Find(x => x.gameObject.layer == 5);
        go.GetComponent<Renderer>().material.color = Color.red;
    }
}
