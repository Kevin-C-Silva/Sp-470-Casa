using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFisica : MonoBehaviour
{
    public Vector3 C;
    // Start is called before the first frame update
    void Start()
    {
        C.x = 0f;
        C.y = 1.5f;
        C.z = -10f;
        transform.position = C;

    }

    // Update is called once per frame
    void Update()
    {
        if(C.y < 1.5f)
        {
            C.y = 1.5f;
            transform.position = C;
        }
        if (Input.GetKey(KeyCode.W))
        {
            C.x = 0f;
            C.y = 0f;
            C.z += 0.5f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            C.x = 0f;
            C.y = 0f;
            C.z += -0.5f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            C.x = 0.5f;
            C.y = 0f;
            C.z += 0f;
        }
    }
}
