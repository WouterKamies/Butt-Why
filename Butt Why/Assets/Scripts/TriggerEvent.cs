using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public GameManager gameManager;

    public bool spacePressed = false;

    public bool inCollider = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inCollider = true;
        }
        else inCollider = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            spacePressed = true;
        }
        else
        {
            spacePressed = false;
        }

        if (inCollider == true && spacePressed == true)
        {
            gameManager.GameOver();
            gameManager.busted();
        }

        if (inCollider == false && spacePressed == true)
        {
            //StartCoroutine(Pause());
            Debug.Log("Nope");
        }

       // IEnumerator Pause()
       // {
            //GameObject bouncer = GameObject.Find("Bouncer");
            //bouncer.GetComponent<BouncerMovement>().enabled = false;
            //Task.Delay(2000).Wait();
            //bouncer.GetComponent<BouncerMovement>().enabled = true;
        //}
    }
}
