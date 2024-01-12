using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Link Test Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
