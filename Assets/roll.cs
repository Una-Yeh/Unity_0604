using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roll : MonoBehaviour
{
    float rotateSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotateSpeed = 10;
        }

        /// 開始旋轉
        transform.Rotate(0, 0, rotateSpeed);

        /// 慢慢停下來
        rotateSpeed *= 0.98f;
    }
}
