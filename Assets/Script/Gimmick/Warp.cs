using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    //でてたくるオブジェクト
    public GameObject _target;
    bool _hit = false; //入る時のオブジェクトの当たり判定
    // Start is called before the first frame update
   

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "player")
        {
            if(_hit == false)
            {
                _hit = true;
                _target.GetComponent<Warp>()._hit = true;
                col.gameObject.transform.position = _target.transform.position;

            }
        }

    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag== "player")
        {
            _hit = false;
        }
    }
}
