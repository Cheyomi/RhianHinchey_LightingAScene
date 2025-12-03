using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Canvas;

    public void PlayGameTriggers()
    {
        SceneManager.LoadScene("HospitalTriggers");
        Canvas.SetActive(false);
    }

    public void LoadSceneNoTriggers()
    {
        SceneManager.LoadScene("HospitalNoTriggers");
        Canvas.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
