using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ChangeScene : MonoBehaviour
{

    public int scene;

    public Image black;
    public Animator anim;

    void OnTriggerEnter(Collider other)
    {
            StartCoroutine(Fading());    
            SceneManager.LoadScene(scene);
    }

    IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        //SceneManager.LoadScene(scene);
    }
}
