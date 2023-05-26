using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour
{

    [SerializeField] private GameObject platform;
    Vector3 lastPos;
    float size;


    void Start()
    {
        lastPos = platform.transform.position;
        size = platform.transform.localScale.x;

        for (int i = 0; i < 250; i++)
        {
            GeneratePlatforms();
        }
    }

    void GeneratePlatforms()
    {
        int random = Random.Range(0,2);
        if (random == 0)
            Spawn(true);
        else if (random == 1)
            Spawn(false);
        

    }

    void Spawn(bool X)
    {
        Vector3 pos = lastPos;
        if (X)
        {
            pos.x += size;
        }
        else
        {
            pos.z += size;
        }

        Instantiate(platform, pos, Quaternion.identity);
        lastPos = pos;
    }

}
