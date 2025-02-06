using UnityEngine;

public class DeathZone : MonoBehaviour, IStateGame
{
    private readonly string _playerName = "Player";

    public bool IsGame { get; set; }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == _playerName)
        {
            IsGame = false;
        }

        Destroy(collision.gameObject);
    }
}
