using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

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
        float Horz = CrossPlatformInputManager.GetAxis("Horizontal");
        float Vert = CrossPlatformInputManager.GetAxis("Vertical");

        RotX += Vert * Time.deltaTime * RotSpeed;
        RotY += Horz * Time.deltaTime * RotSpeed;

        Quaternion YRot = Quaternion.Euler(0f, RotY, 0f);
        DestRot = YRot * Quaternion.Euler(RotX, 0f, 0f);

        ThisTransform.rotation = DestRot;

        ThisTransform.position = Pilov.position + ThisTransform.rotation * Vector3.forward * -PivotDistance;
    }
}
