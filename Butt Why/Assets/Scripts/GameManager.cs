using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject bustedUI;

    public void busted ()
    {
        bustedUI.SetActive(true);
    }

    public void GameOver ()
    {
        Debug.Log("Busted");
    }
}
