using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    [SerializeField]
    public GameObject _playBtn;
    private GameObject _planet;         //惑星
    private bool _btnFlag;              //ドラックフラグ
    [SerializeField]
    public Rigidbody2D _rigidStar;      //星リジットボディー
    public bool _collisionFlag = false; //回転フラグ
    private bool _playFlag = false;
    // Update is called once per frame
    void Update()
    {

        _playFlag = _playBtn.GetComponent<PlayAndStop>()._clickFlag;
        //ドラック＆ドロップし終わったなら

        _planet = GameObject.FindWithTag("Planet");
        

        //回転フラグtrueなら
        if (_collisionFlag == true)
        {
            gameObject.transform.localPosition += (gameObject.transform.position - _planet.transform.position).normalized / 5 * Time.deltaTime;
            gameObject.transform.RotateAround(_planet.transform.position, Vector3.back, 60 * Time.deltaTime);
        }
    }

    //回転フラグ
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Planet" && _playFlag == true)
        {
            _collisionFlag = true;
            _rigidStar.velocity = Vector3.zero;
        }
    }
}
