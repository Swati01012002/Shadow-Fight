using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public void SceneLoaderNext(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void SceneLoaderPrevious(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void SceneReset()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("App has quit");
    }



}