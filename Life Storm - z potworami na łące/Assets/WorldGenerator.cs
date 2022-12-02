using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{

    [SerializeField] public GameObject cube;
    public  GameObject cam;
    public float[,] array = new float[150,150];
    public Vector3 pos;
    public int[] ints = new int[100];
    // Start is called before the first frame update
    public void Start()
    {
        worldGenerate();
    }

    public void worldGenerate()
    {
        for(int i = 0; i < 15000; i+=10)
            for(int j = 0; j < 15000; j+=10)
                Instantiate(cube, new Vector3(i, 0, j), Quaternion.identity);
    }
}
