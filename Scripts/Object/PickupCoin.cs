using UnityEngine;

public class PickupCoin : MonoBehaviour
{
    public AudioClip sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioManager.instance.PlayClipAt(sound, transform.position);
            Inventory.instance.AddGems(1);
            CurrentSceneManager.instance.GemsPickedUpInThisCount++; 
            Destroy(gameObject);
        }
    }
}
