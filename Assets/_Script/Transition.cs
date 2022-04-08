using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public GameObject _configPanel;
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void ConfigPanel()
    {
        _configPanel.SetActive(true);
    }
    public void Return()
    {
        _configPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit(1);
    }
}
