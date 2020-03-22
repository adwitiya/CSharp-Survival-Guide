using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Vector3 startPos;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube.transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
