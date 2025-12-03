using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void PlayGameTriggers()
    {
        SceneManager.LoadScene("HospitalTriggers");
    }

    public void LoadSceneNoTriggers()
    {
        SceneManager.LoadScene("HospitalNoTriggers");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
