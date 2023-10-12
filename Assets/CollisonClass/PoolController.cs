using System.Collections.Generic;
using UnityEngine;
public class PoolController : MonoBehaviour
{
    [SerializeField]private List<GameObject> ObjectsList;
    [SerializeField]private GameObject Balls;
    [SerializeField]private int initObjects;
    public static PoolController instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        CompletePool(initObjects);
    }
    public void CompletePool(int number)
    {
        for(int i = 0; i < number; i++)
        {
            GameObject go = Instantiate(Balls, this.transform);
            go.SetActive(false);
            ObjectsList.Add(go);
        }
    }
    private void ChangeColor(GameObject go)
    {
        float Rangomr = Random.Range(0.0f, 1.0f);
        float Rangomg = Random.Range(0.0f, 1.0f);
        float Rangomb = Random.Range(0.0f, 1.0f);
        float Rangoma = Random.Range(0.0f, 1.0f);
        go.gameObject.GetComponent<Renderer>().material.color = new Color(Rangomr, Rangomg, Rangomb, Rangoma);
        print("PoolControllerComponent");
    }
    public GameObject GetBall()
    {
        foreach (GameObject go in ObjectsList)
        {
            if (!go.activeSelf)
            {
                go.SetActive(true);
                go.GetComponent<BallScript>().Notify += ChangeColor;
                return go;
            }
        }
        CompletePool(1);
        GameObject auxBall = ObjectsList[ObjectsList.Count - 1];
        auxBall.SetActive(true);
        auxBall.GetComponent<BallScript>().Notify += ChangeColor;
        return auxBall;
    }
}
