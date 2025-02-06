using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private readonly string _player = "Player";

    [SerializeField] private float _speedEnemy;
    [SerializeField] private float _gravityScale = 5;

    private Rigidbody _rigidBodyEnemy;
    private GameObject _playerPosition;

    private void Start()
    {
        _rigidBodyEnemy = GetComponent<Rigidbody>();
        _playerPosition = GameObject.Find(_player);
    }

    private void Update()
    {
        if (_playerPosition != null)
        {
            MoveEnemyToThePlayer();
        }
    }

    private void MoveEnemyToThePlayer()
    {
        Vector3 lookDirection = (_playerPosition.transform.position - transform.position).normalized;

        _rigidBodyEnemy.AddForce(Physics.gravity * (_gravityScale - 1) * _rigidBodyEnemy.mass);
        _rigidBodyEnemy.AddForce(lookDirection * _speedEnemy);
    }
}
