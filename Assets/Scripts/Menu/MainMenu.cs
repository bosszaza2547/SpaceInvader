using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Closegame()
    {
        Application.Quit();
    }
    public void Playgame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void Selectskill()
    {
        SceneManager.LoadScene("Skill Selection");
    }
}
