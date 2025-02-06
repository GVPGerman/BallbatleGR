using System.Collections;
using UnityEngine;

public class PlayerPowerUp : RepellingCharacter
{
    private readonly string _powerupName = "Powerup";
    private readonly string _enemyName = "Enemy";

    [SerializeField, Range(1, 10)] private float _powerUpStrenght;

    private bool _isPowerUp = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_powerupName))
        {
            _isPowerUp = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerUpCountDownRoutine());
        }
    }

    private IEnumerator PowerUpCountDownRoutine()
    {
        yield return new WaitForSeconds(7);
        _isPowerUp = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(_enemyName) && _isPowerUp)
        {
            Repelling(collision, _powerUpStrenght);
        }
    }
}
