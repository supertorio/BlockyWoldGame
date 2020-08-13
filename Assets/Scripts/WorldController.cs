﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    public GameObject block;
    public int worldSize = 2;

    public IEnumerator BuildWorld()
    {
        for (int z = 0; z < worldSize; z++)
        {
            for (int y = 0; y < worldSize; y++)
            {
                for (int x = 0; x < worldSize; x++)
                {
                    Vector3 pos = new Vector3(x, y, z);
                    GameObject cube = GameObject.Instantiate(block, pos, Quaternion.identity);
                    cube.name = x + "_" + y + "_" + z;
                }
                yield return null;
            }
        }
    }

    public void Start()
    {
        StartCoroutine(BuildWorld());
    }
}
