using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    private readonly string _horizontal = "Horizontal";

    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        float horizontalInput = Input.GetAxis(_horizontal);

        transform.Rotate(Vector3.up, -horizontalInput * _rotationSpeed * Time.deltaTime);
    }
}
