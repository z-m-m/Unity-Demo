using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject cameraObject;
    private Vector3 tempPos;

    private void Start()
    {
        tempPos = transform.position - cameraObject.transform.position;
    }

    private void Update()
    {
     cameraObject.transform.position = Vector3.Lerp(Vector3.zero, transform.position - tempPos,1);      
    }

}
