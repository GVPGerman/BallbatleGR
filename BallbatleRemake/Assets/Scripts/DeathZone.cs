using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private SpawnerManager _spawnerManagerScript;

    private void Start()
    {
        _spawnerManagerScript = GetComponent<SpawnerManager>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            _spawnerManagerScript._isGame = false;
        }

        Destroy(collision.gameObject);
    }
}
