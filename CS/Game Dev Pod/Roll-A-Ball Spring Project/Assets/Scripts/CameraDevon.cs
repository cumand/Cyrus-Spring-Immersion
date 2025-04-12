using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDevon : MonoBehaviour
{  
    public GameObject target;
    public Vector3 positionOffset;
    
    void Start()
    {

    }


    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null) // If the camera has a target to follow
        {
            transform.position = target.transform.position + positionOffset;
        } 
        else
        {
            Debug.LogWarning("Camera has no target to follow!");
        }
    }
}
