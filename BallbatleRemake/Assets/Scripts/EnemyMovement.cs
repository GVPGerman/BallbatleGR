using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speedEnemy;
    private Rigidbody _rigidBodyEnemy;
    private GameObject _playerPosition;

    private void Start()
    {
        _rigidBodyEnemy = GetComponent<Rigidbody>();
        _playerPosition = GameObject.Find("Player");
    }

    private void Update()
    {
        MoveEnemyToThePlayer();
        DestroyEnemyAbroad();
    }
    private void MoveEnemyToThePlayer()
    {
        Vector3 lookDirection = (_playerPosition.transform.position - transform.position).normalized;

        _rigidBodyEnemy.AddForce(lookDirection * _speedEnemy);
    }

    private void DestroyEnemyAbroad()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}