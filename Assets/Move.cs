using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        // Rotate left when pressing A
        if (Input.GetKey(KeyCode.A))
        {
            RotateCamera(-rotationSpeed * Time.deltaTime);
        }

        // Rotate right when pressing D
        if (Input.GetKey(KeyCode.D))
        {
            RotateCamera(rotationSpeed * Time.deltaTime);
        }
    }

    void RotateCamera(float angle)
    {
        // Rotate the GameObject (camera) around its y-axis
        transform.Rotate(Vector3.up, angle);
    }
}
