using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string SceneName;

    private void Update()
    {
       //0 - left, 1 - right, 2 - middle
        if (Input.GetMouseButtonDown(0))
        {
            SwitchScene();
        }
    }
    void SwitchScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
