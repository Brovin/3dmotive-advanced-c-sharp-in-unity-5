using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiter : MonoBehaviour
{
    public Transform Pilov = null;
    private Transform ThisTransform = null;
    private Quaternion DestRot = Quaternion.identity;
    public float PivotDistance = 5f;
    public float RotSpeed = 10f;
    private float RotX = 0f;
    private float RotY = 0f;
    // Start is called before the first frame update
    void Awake()
    {
        ThisTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
