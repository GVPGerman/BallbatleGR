using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private readonly string _focalPointName = "FocalPoint";
    private readonly string _verticalAxisName = "Vertical";

    [SerializeField] private float _speedPlayer;
    [SerializeField] private float _gravityScale;

    private Rigidbody _rigidBodyPlayer;
    private GameObject _focalPoint;

    private void Start()
    {
        _rigidBodyPlayer = GetComponent<Rigidbody>();
        _focalPoint = GameObject.Find(_focalPointName);
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float verticalInput = Input.GetAxis(_verticalAxisName);

        _rigidBodyPlayer.AddForce(Physics.gravity * (_gravityScale - 1) * _rigidBodyPlayer.mass);
        _rigidBodyPlayer.AddForce(_focalPoint.transform.forward * _speedPlayer * verticalInput);
    }
}