using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Matrix : MonoBehaviour
{
    [SerializeField]private List<Cube> cubes;
    private readonly int size = 3;
    private Cube[,] cube_matrix;
    void Start()
    {
        cube_matrix = new Cube[size, size];
        cubes = new List<Cube>(GameObject.FindObjectsOfType<Cube>());
        cubes = cubes.OrderBy(c => c.INDEX).ToList();
        int list = 0;
        for(int i = 0; i < size; i++)
        {
            for(int x = 0; x < size; x++)
            {
                cube_matrix[i,x] = cubes[list];
                list++;
                print(cube_matrix[i,x]);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
