using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    //public int sceneIndex; 

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
        int scneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scneIndex);
    }
    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("App has quit");
    }
}