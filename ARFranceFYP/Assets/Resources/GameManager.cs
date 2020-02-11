using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float delay = 0.5f;
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void NextSceneDelay()
    {
        StartCoroutine(NextSceneIE());
    }
    public void NextXTwoSceneDelay()
    {
        StartCoroutine(NextXTwoSceneIE());
    }
    public void NextXThreeSceneDelay()
    {
        StartCoroutine(NextXThreeSceneIE());
    }


    public void PreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void PreviousSceneDelay()
    {
        StartCoroutine(PreviousSceneIE());
    }

    public void PrevioustXTwoScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void PreviousXThreeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
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
    IEnumerator NextXTwoSceneIE()
    {
        Debug.Log("wait");
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    IEnumerator NextXThreeSceneIE()
    {
        Debug.Log("wait");
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    IEnumerator PreviousSceneIE()
    {
        Debug.Log("wait");
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
   /* IEnumerator PreviousXTwoSceneIE()
    {
        Debug.Log("wait");
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    IEnumerator PreviousXThreeSceneIE()
    {
        Debug.Log("wait");
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }*/
}
