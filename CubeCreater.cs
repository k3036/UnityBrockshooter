using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreater : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Create", 0f, 6f);
    }

    // Update is called once per frame
    void Create()
    {
        float random = Random.Range(-2.0f, 2.0f);
        Vector2 createPos = new Vector2(transform.position.x + random, transform.position.y);
        Instantiate(cube, createPos, Quaternion.identity);
    }
}
