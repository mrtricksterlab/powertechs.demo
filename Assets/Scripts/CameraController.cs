using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 0.5f; // Adjust the sensitivity of the mouse movement

    private void Update()
    {
        RotateCamera();
    }

    void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotate the camera around the y-axis (left/right)
        transform.Rotate(Vector3.up, mouseX * sensitivity);

        // Rotate the camera around the x-axis (up/down)
        transform.Rotate(Vector3.left, mouseY * sensitivity);

        Vector3 currentRotation = transform.localRotation.eulerAngles;
        currentRotation.z = 0;
        transform.localRotation = Quaternion.Euler(currentRotation);
    }
}
