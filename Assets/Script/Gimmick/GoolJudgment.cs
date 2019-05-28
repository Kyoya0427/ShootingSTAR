
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoolJudgment : MonoBehaviour
{
    [SerializeField]
    public Rigidbody2D _rigidStar;
    private bool _colFlag;

    void Start()
    {
        _colFlag = false;
    }

    void Update()
    {
        if(_colFlag == true)
        {
            Invoke("ChangeScene", 3.0f);
        }
    }

    void ChangeScene()
    {
        Debug.Log("a");
        SceneManager.LoadScene("ClearScene");
    }

    //ゴール判定
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Gool")
        {
            _colFlag = true;
            _rigidStar.velocity = Vector3.zero;
            _rigidStar.angularVelocity = 0.0f;
        } 
    }
}
