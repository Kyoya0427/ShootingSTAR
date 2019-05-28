using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextPlayScene : MonoBehaviour
{
    [SerializeField]
    public GameObject _fadeScript;
    private bool _clickFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        _fadeScript.GetComponent<FadeInOut>()._fadeInFlag = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && _fadeScript.GetComponent<FadeInOut>()._fadeInFlag == false)
        {
            _clickFlag = true;
            _fadeScript.GetComponent<FadeInOut>()._fadeOutFlag = true;
        }

        if (_fadeScript.GetComponent<FadeInOut>()._fadeOutFlag == false && _clickFlag == true)
        {
            SceneManager.LoadScene("Stage1");
        }
    }
}
