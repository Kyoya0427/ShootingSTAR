using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PhysicalBehaviorStop : MonoBehaviour
{
   
    private Vector3 startPosition;  //星のポジション
    public GameObject _star;        //星オブジェクト
    public Rigidbody2D _starRigid;  //星リジットボディー
    public GameObject _btn;         //再生停止ボタンオブジェクト

    Image _btnImage;                //ボタンオブジェクトのイメージ
    public Sprite _stopSprite;      //ストップスクリプト
    public Sprite _playSprite;      //スタートスクリプト

    void Start()
    {
        //星のスタートポジション
        startPosition = _star.transform.position;
        _btnImage = _btn.GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {

        bool btnSwitchFlag = _btn.GetComponent<PlayAndStop>()._clickFlag;

        //stateの変化後の処理
        if (btnSwitchFlag == true)
        {
            _btnImage.sprite = _stopSprite;
            Time.timeScale = 1.0f;
        }
        //星の初期値リセットと物理起動停止
        if (btnSwitchFlag == false)
        {
            _btnImage.sprite = _playSprite;
            _star.transform.position = startPosition;
            _starRigid.gravityScale = 1.0f;
            _starRigid.velocity = Vector3.zero;
            Time.timeScale = 0.0f;
        }
    }
}
