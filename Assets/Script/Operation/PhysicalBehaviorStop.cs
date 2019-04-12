using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PhysicalBehaviorStop : MonoBehaviour
{
   
    private Vector3 startPosition;
    public GameObject _star;
    public Rigidbody2D _starRigid;
    public GameObject _btn;

    Image _btnImage;
    public Sprite _stopSprite;
    public Sprite _playSprite;

    void Start()
    {
        startPosition = _circle.transform.position;
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
        if (btnSwitchFlag == false)
        {
            _btnImage.sprite = _playSprite;
            _circle.transform.position = startPosition;
            _circleRigid.velocity = Vector3.zero;
            Time.timeScale = 0.0f;
        }
    }
}
