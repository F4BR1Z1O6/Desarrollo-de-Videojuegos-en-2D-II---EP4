using System.Collections;
using UnityEngine;

public class HidroMiel : MonoBehaviour
{
    public float speedBoost = 10f; 
    public float duration = 3f; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            StartCoroutine(BoostPlayerSpeed(player));
            Destroy(gameObject);
        }
    }

    private IEnumerator BoostPlayerSpeed(PlayerController player)
    {
        player.moveSpeed += speedBoost;
        yield return new WaitForSeconds(duration);
        player.moveSpeed -= speedBoost;
    }
}


