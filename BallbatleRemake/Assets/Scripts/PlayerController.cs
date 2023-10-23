using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speedPlayer;
    private Rigidbody _rigidBodyPlayer;
    private GameObject _focalPoint;

    private void Start()
    {
        _rigidBodyPlayer = GetComponent<Rigidbody>();
        _focalPoint = GameObject.Find("FocalPoint");
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float verticalInput = Input.GetAxis("Vertical");

        _rigidBodyPlayer.AddForce(_focalPoint.transform.forward * _speedPlayer * verticalInput);
    }
}