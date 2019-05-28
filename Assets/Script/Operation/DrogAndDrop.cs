using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrogAndDrop : MonoBehaviour
{
    [SerializeField]
    public GameObject _playBtn;
    private Vector3 _screenPos;
    private Vector3 _worldPos;
    private Vector3 _offset;
    private bool    _onMouseEnterFlag = false;
    private bool    _playFlag = false;


    void Start()
    {
       
    }

    void Update()
    {
        _playFlag = _playBtn.GetComponent<PlayAndStop>()._clickFlag;

        if (_playFlag)
        {
            return;
        }

        _screenPos = Input.mousePosition;
        _screenPos.z = 10.0f;
        _worldPos = Camera.main.ScreenToWorldPoint(_screenPos);
        Vector3 offset = _worldPos - transform.position;
    
        if (offset.magnitude < 2.0f && Input.GetMouseButton(0) || 
            _onMouseEnterFlag && Input.GetMouseButton(0))
        {
            if (!_onMouseEnterFlag)
            {
                _offset = offset;
            }
            _onMouseEnterFlag = true;
        }
        else
        {
            _onMouseEnterFlag = false;
        }

        if (_onMouseEnterFlag)
        {
            //Debug.Log(_offset);
            if (Input.GetMouseButton(0)) {
                transform.position = _worldPos - _offset;
            }
        }

    }

}
