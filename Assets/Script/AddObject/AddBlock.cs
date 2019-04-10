using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class AddBlock : MonoBehaviour
{
    
    public  bool _pushButtonFlag = false;

    // Start is called before the first frame update
    void Update()
    {
       
    }


    public void EventTriggerDown()
    {
        EventTrigger.Entry pressDown = new EventTrigger.Entry();
        pressDown.eventID = EventTriggerType.PointerDown;       //イベントのタイプ設定
        pressDown.callback.AddListener((data) => { PushJudgment(); });   //メソッド登録

        //イベントトリガーにイベント追加
        GetComponent<EventTrigger>().triggers.Add(pressDown);
        
    }

    public void PushJudgment()
    {
        _pushButtonFlag = true;
        gameObject.SetActive(false);
 
    }

    
}
