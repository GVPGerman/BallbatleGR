using UnityEngine;

public class EnemyStrenght : RepellingCharacter
{
    private readonly string _player = "Player";

    [SerializeField, Range(1, 10)] private float _strenghtEnemy;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(_player))
        {
            Repelling(collision, _strenghtEnemy);
        }
    }
}
