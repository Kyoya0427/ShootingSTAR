using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    public static string _loadSceneName;
    // Start is called before the first frame update
    void Start()
    {
        _loadSceneName = SceneManager.GetActiveScene().name;

    }
    public void OnClick()
    {
        SceneManager.LoadScene(_loadSceneName);
    }

    public static string GetSceneName()
    {
        return _loadSceneName;
    }
}
