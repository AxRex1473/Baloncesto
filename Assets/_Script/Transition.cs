using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public GameObject _configPanel;
    public ParticleSystem _playParticles;
    public GameObject _buttonPlay;
    public GameObject _buttonConfig;
    public GameObject _buttonReturn;

    public void PlayGame()
    {
        Instantiate(_playParticles, _buttonPlay.transform.position, Quaternion.identity);
        StartCoroutine(TransitionWait());
    }

    public void ConfigPanel()
    {
        Instantiate(_playParticles, _buttonConfig.transform.position, Quaternion.identity);
        _configPanel.SetActive(true);
        DestroyParticles();
    }

    public void Return()
    {
        Instantiate(_playParticles, _buttonReturn.transform.position, Quaternion.identity);
        _configPanel.SetActive(false);
        DestroyParticles();
    }

    public void ExitGame()
    {
        Application.Quit(1);
    }

    public void DestroyParticles()
    {
        Destroy(_playParticles, 3f);
    }

    public void ToMain()
    {
        SceneManager.LoadScene("Index");
    }

    public void ToAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public IEnumerator TransitionWait()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("SampleScene");
    }
}
