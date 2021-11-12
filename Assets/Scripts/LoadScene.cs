using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   
    public void btn_changeScene(int scene_id)
    {
        SceneManager.LoadScene(scene_id);
    } 
}
