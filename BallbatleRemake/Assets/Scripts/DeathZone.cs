using UnityEngine;

public class DeathZone : MonoBehaviour
{
    protected bool isGame = true;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            isGame = false;
        }

        Destroy(collision.gameObject);
    }
}
