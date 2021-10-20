using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Camera myCamera;
    // Start is called before the first frame update
    void Start()
    {
        myCamera = gameObject.GetComponent<Camera>();
        Debug.Log("myCamera attached to " + myCamera.name);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            myCamera.transform.Rotate(-0.05f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            myCamera.transform.Rotate(0.05f, 0f, 0f);
        }
    }
}
