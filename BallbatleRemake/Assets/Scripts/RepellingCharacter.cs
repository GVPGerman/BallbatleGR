using UnityEngine;

public class RepellingCharacter : MonoBehaviour
{
    protected void Repelling(Collision collision, float strenght)
    {
        Rigidbody enemyRigidBody = collision.gameObject.GetComponent<Rigidbody>();
        Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;

        enemyRigidBody.AddForce(awayFromPlayer * strenght, ForceMode.Impulse);
    }
}
