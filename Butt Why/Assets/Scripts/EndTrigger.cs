using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag ("Player"))
        {
            Debug.Log("Busted!");
        }
    }

}
