using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float _speedEnemy;
    private Rigidbody _rigidBodyEnemy;
    private GameObject _playerPosition;

    [SerializeField] private bool _isStrenght = false;
    private float _strenghtEnemy = 7;

    private void Start()
    {
        _rigidBodyEnemy = GetComponent<Rigidbody>();
        _playerPosition = GameObject.Find("Player");
    }

    private void Update()
    {
        MoveEnemyToThePlayer();
        DestroyEnemy();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && _isStrenght)
        {
            Rigidbody enemyRigidBody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;

            enemyRigidBody.AddForce(awayFromPlayer * _strenghtEnemy, ForceMode.Impulse);
        }
    }

    private void MoveEnemyToThePlayer()
    {
        Vector3 lookDirection = (_playerPosition.transform.position - transform.position).normalized;

        _rigidBodyEnemy.AddForce(lookDirection * _speedEnemy);
    }

    private void DestroyEnemy()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
