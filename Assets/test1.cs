using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    public int a;

    // Start is called before the first frame update
    void Start()
    {
        a = 100;
        Debug.Log(a);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }
}
