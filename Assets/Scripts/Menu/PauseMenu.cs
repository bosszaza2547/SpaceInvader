using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausemenu;
    public void Returntomenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Pause()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Unpause()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1;
    }
}
