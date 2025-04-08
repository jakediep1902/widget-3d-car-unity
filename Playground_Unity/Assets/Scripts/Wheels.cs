using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Wheels : MonoBehaviour, IActions
{
    public Slider accelerationSli;
    public CarController car; 
    public static float baseRotationSpeed = 1f; // Base rotation speed
    [Range(-10,100)]
    public static float moveSpeed = 1f;
    public static float lastSpeed = 0f;
    public static float acceleration = 0.002f;
    
    private void Start()
    {
        
        baseRotationSpeed = 10f;
        moveSpeed = 0f;
    }
    void Update()
    {     
        RotateWheel(moveSpeed);
        car.MoveCar(moveSpeed);
    }
    public void RotateWheel(float speedMultiplier)
    {
       
        float finalSpeed = baseRotationSpeed * speedMultiplier; // Scale speed
        finalSpeed = Mathf.Lerp(lastSpeed, finalSpeed, acceleration);
        transform.Rotate(-Vector3.forward * finalSpeed * Time.deltaTime);
        lastSpeed = finalSpeed;
    }

    public void ActiveFunctionsByAction(string actionName, string options)
    {
        switch(actionName)
        {
            case "speed":
                float speed = float.Parse(options);
                speed = Mathf.Clamp(speed, -20, 120);             
                SetMoveSpeedAllWheels(speed);
                car.MoveCar(speed);
                break;
        }
    }
    public static void SetMoveSpeedAllWheels(float speed)
    {     
            moveSpeed = speed;
    }
    public void SetMoveSpeedAllWheelsTest()
    {
        moveSpeed = accelerationSli.value;
    }

}
