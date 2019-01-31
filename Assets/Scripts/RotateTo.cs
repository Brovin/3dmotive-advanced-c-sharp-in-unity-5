using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTo : MonoBehaviour
{
    private Transform ThisTransform = null;
    public float RotSpeed = 90f;
    public Transform Target = null;
    void Awake()
    {
        ThisTransform = GetComponent<Transform>();
    }

    // Update is called once per frame 
    void Update()
    {
        Quaternion DestRot = Quaternion.LookRotation(Target.position - ThisTransform.position, Vector3.up);
        ThisTransform.rotation = Quaternion.RotateTowards(ThisTransform.rotation, DestRot, RotSpeed * Time.deltaTime);
        //ThisTransform.rotation *= Quaternion.AngleAxis(RotSpeed * Time.deltaTime, Vector3.up);
    }
}
