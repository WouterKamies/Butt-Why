using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject bustedUI;

    public GameObject bouncer;

    //int bouncerDelay = 2000;

    public void busted ()
    {
        bustedUI.SetActive(true);
    }

    public void GameOver ()
    {
        Debug.Log("Busted");
    }

    //public void bouncerInput()
    //{
        //bouncer.GetComponent<BouncerMovement>().enabled = false;

        

        //bouncer.GetComponent<BouncerMovement>().enabled = true;
    //}
}
