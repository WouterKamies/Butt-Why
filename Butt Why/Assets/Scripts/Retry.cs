using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
