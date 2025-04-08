using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrunkFront : MonoBehaviour
{
    public float targetAngle = 90f; 
    public float rotationSpeed = 30f; 

    private bool isRotating = false; 

    void Update()
    {
        if (isRotating)
        {
            RotateToY(targetAngle);
        }
    }

    public void StartRotation(float newAngle)
    {
        targetAngle = newAngle;
        isRotating = true;
    }

    void RotateToY(float angle)
    {
        float currentY = transform.localEulerAngles.y;
        float newY = Mathf.MoveTowardsAngle(currentY, angle, rotationSpeed * Time.deltaTime);
        transform.localRotation = Quaternion.Euler(transform.localEulerAngles.x, newY, transform.localEulerAngles.z);

        if (Mathf.Approximately(newY, angle))
        {
            isRotating = false;
        }
    }
}
