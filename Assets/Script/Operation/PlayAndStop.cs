using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAndStop : MonoBehaviour
{
    [SerializeField]
    public GameObject _revolutionObj;
    [SerializeField]
    public GameObject _gravitationObj;
    public bool _clickFlag = false;    //クリック判定
  
    public void OnClick()
    {
        if(_clickFlag == false)
        {
            _clickFlag = true;
            _revolutionObj.GetComponent<Revolution>()._collisionFlag = false;
            _gravitationObj.GetComponent<Gravitation>()._gravitFlag = false;
        }
        else if(_clickFlag == true)
        {
            _clickFlag = false;
        }
    }
}
