using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAndStop : MonoBehaviour
{
    public bool _clickFlag = false;    //クリック判定

    public void OnClick()
    {
        if(_clickFlag == false)
        {
            _clickFlag = true;
        }
        else if(_clickFlag == true)
        {
            _clickFlag = false;
        }
    }
}
