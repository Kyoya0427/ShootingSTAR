using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OneMore : MonoBehaviour
{
    private string _stageName;

    
    void Start()
    {
        _stageName = ResetScene.GetSceneName();

    }

    public void OnClick()
    {
        SceneManager.LoadScene(_stageName);
    }
}
