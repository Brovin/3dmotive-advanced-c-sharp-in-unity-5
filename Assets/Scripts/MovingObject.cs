using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float MaxSpeed = 1f;
    private Transform ThisTransform = null;

    void Awake()
    {
        ThisTransform = GetComponent<Transform>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        ThisTransform.position += ThisTransform.forward * MaxSpeed * Time.deltaTime;
    }
}
