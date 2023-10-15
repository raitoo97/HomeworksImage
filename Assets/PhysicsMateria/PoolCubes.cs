using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolCubes : MonoBehaviour
{
    public static PoolCubes instance;
    [SerializeField]private List<GameObject> CubesList;
    public GameObject Cube;
    public int Size;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        InitList(Size);
    }
    private void InitList(int num)
    {
        for(int i = 0; i < num; i++)
        {
            GameObject go = Instantiate(Cube,this.transform);
            go.SetActive(false);
            CubesList.Add(go);
        }
    }
    public GameObject GetCube()
    {
        foreach (GameObject go in CubesList)
        {
            if (!go.activeSelf)
            {
                go.SetActive(true);
                return go;
            }
        }
        InitList(1);
        GameObject AuxBall = CubesList[CubesList.Count - 1];
        AuxBall.SetActive(true);
        return AuxBall;
    }
}
