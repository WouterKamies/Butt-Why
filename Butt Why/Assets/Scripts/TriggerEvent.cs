using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.GameOver();
            gameManager.busted();
        }
    }
}
