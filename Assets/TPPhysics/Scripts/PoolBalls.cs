using System;
using System.Collections.Generic;
using UnityEngine;
public class PoolBalls : MonoBehaviour
{
    public static PoolBalls instance;
    [SerializeField] private List<GameObject> ball_list;
    public GameObject ball;
    private int init_list;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        init_list = 30;
    }
    private void Start()
    {
        CompletPool(init_list);
    }
    private void CompletPool(int number)
    {
        for(int i = 0; i < number; i++)
        {
            GameObject go = Instantiate(ball, this.transform);
            ball_list.Add(go);
            go.SetActive(false);
        }
    }
    public GameObject ReturnBall()
    {
        foreach(var index in ball_list)
        {
            if (!index.activeSelf)
            {
                index.SetActive(true);
                index.GetComponent<Rigidbody>().velocity = Vector3.zero;
                return index;
            }
        }
        CompletPool(1);
        var Aux = ball_list[ball_list.Count - 1];
        Aux.SetActive(true);
        Aux.GetComponent<Rigidbody>().velocity = Vector3.zero;
        return Aux;
    }
}
