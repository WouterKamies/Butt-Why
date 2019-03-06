using UnityEngine;

public class TriggerEven : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Busted");
        }
    }
}