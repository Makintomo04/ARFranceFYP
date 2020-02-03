using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float delay = 0.5f;
    public void NextSceneDelay()
    {
        StartCoroutine(NextSceneIE());
    }
    public void PreviousSceneDelay()
    {
        StartCoroutine(PreviousSceneIE());
    }
    public void PreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        StartCoroutine(QuitIE());
    }
    IEnumerator QuitIE()
    {
        Debug.Log("wait");
        yield return new WaitForSeconds(delay);
        Application.Quit();
    }

    IEnumerator NextSceneIE()
    {
        Debug.Log("wait");
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    IEnumerator PreviousSceneIE()
    {
        Debug.Log("wait");
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
