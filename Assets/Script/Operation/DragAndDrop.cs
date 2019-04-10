using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public GameObject _addBox;
    private GameObject _moveBox;
    Vector3 _screenPos;
    Vector3 _worldPos;
    public GameObject _btn;
    bool _btnFlag;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _btnFlag = _btn.GetComponent<AddBlock>()._pushButtonFlag;

        if (Input.GetMouseButtonDown(0) && _btnFlag == true)
        {
            _moveBox = Instantiate(_addBox);
        }

        if (Input.GetMouseButton(0) && _btnFlag == true)
        { 
            _screenPos = Input.mousePosition;
            _screenPos.z = 10.0f;
            _worldPos = Camera.main.ScreenToWorldPoint(_screenPos);
            _moveBox.transform.position = _worldPos;
        }

        if (Input.GetMouseButtonUp(0) && _btnFlag == true)
        {
            _btn.GetComponent<AddBlock>()._pushButtonFlag = false;
            
        }
    }


}
