using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2Handling : MonoBehaviour
{
    public Camera camera2;
    [SerializeField] Transform target2; // The object to rotate around
    [SerializeField] float rotationSpeed = 1f; // Speed of rotation
    private bool isRotating = false;
    private Vector3 lastMousePosition;

    private void Update()
    {
        if (!isRotating && Input.GetMouseButtonDown(0) && IsWithinCameraViewport(Input.mousePosition))
        {
            isRotating = true;
            lastMousePosition = Input.mousePosition;
        }

        if (isRotating)
        {
            if (Input.GetMouseButtonUp(0))
            {
                isRotating = false;
            }

            Vector3 deltaMousePosition = Input.mousePosition - lastMousePosition;
            float rotationAmountHorizontal = deltaMousePosition.x * rotationSpeed * Time.deltaTime;
            float rotationAmountVertical = -deltaMousePosition.y * rotationSpeed * Time.deltaTime;

            transform.RotateAround(target2.position, Vector3.up, rotationAmountHorizontal);
            transform.RotateAround(target2.position, transform.right, rotationAmountVertical);

            lastMousePosition = Input.mousePosition;
        }
    }

    // Check if the given mouse position is within the camera's viewport
    private bool IsWithinCameraViewport(Vector3 mousePosition)
    {
        Vector3 viewportMousePosition = camera2.ScreenToViewportPoint(mousePosition);
        return viewportMousePosition.x >= 0f && viewportMousePosition.x <= 1f &&
        viewportMousePosition.y >= 0f && viewportMousePosition.y <= 1f;
    }
}
