using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Softparenting : MonoBehaviour
{
   
    public Transform parent; 
    private Vector3 relativePosition;
    private Vector3 relativeAxisY;
    private Vector3 relativeAxisZ;
    

    private void Awake()
    {
        
        relativePosition = parent.InverseTransformPoint(transform.position);
        relativeAxisY = parent.InverseTransformVector(transform.up);
        relativeAxisZ = parent.InverseTransformVector(transform.forward);

    }

    private void Update()
    {
        transform.position = parent.position+parent.TransformVector(relativePosition);

        Quaternion targetRotation = Quaternion.LookRotation(parent.TransformVector(relativeAxisZ), parent.TransformVector(relativeAxisY));
        
    }
}


