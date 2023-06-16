using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public Animator animator;

    void OnTransition(int index)
    {
        StartCoroutine(Load(index));
    }

    IEnumerator Load(int index)
    {
        animator.SetTrigger("end");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(index);
    }
}
