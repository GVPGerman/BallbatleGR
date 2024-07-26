using UnityEngine;

public class EnemyStrenght : MonoBehaviour
{
    private float _strenghtEnemy = 7;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody enemyRigidBody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;

            enemyRigidBody.AddForce(awayFromPlayer * _strenghtEnemy, ForceMode.Impulse);
        }
    }
}
