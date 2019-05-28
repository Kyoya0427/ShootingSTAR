using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravitation : MonoBehaviour
{
    [SerializeField]
    public GameObject _playBtn;
    public static float _UniversalGravity = 6.67259f; //万有引力定数の定義
    public Rigidbody2D _planetBody;                   //惑星のリジットボディー
    public bool _gravitFlag = false;                  //重力起動しているか？
    GameObject  _star;                                //星オブジェクト
    Rigidbody2D _starRigid;                           //星のリジットボディー
    private bool _playFlag = false;

    // Use this for initialization
    void Start()
    {
        //星のデータ取得
        _star = GameObject.FindWithTag("Star");
        _starRigid = _star.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {

        _playFlag = _playBtn.GetComponent<PlayAndStop>()._clickFlag;
 
        //重力フラグ起動、回転フラグ停止なら
        if (_gravitFlag == true && _star.GetComponent<Revolution>()._collisionFlag == false)
        {
            UniversalGravit();
        }
    } 
    //重力処理（万有引力）
    void UniversalGravit()
    {
        Vector3 vec_direction = gameObject.transform.position - _star.transform.position;
        //万有引力の計算
        Vector3 Univ_gravity = _UniversalGravity * vec_direction.normalized * (_planetBody.mass * _starRigid.mass) / (vec_direction.sqrMagnitude) * 10;
        //流れ星に万有引力を掛ける
        _starRigid.AddForce(Univ_gravity);
    }

    //重力範囲判定
    void OnTriggerEnter2D(Collider2D col)
    {
       
        if (col.gameObject.tag == "Star" && _playFlag == true) 
        {
            _starRigid.gravityScale = 0.0f;
           
            _gravitFlag = true;
        }
    }

}
