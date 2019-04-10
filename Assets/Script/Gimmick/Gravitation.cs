using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravitation : MonoBehaviour
{
    public static float _UniversalGravity = 6.67259f; //万有引力定数の定義
    public Rigidbody2D _shootingSterBody;
    public GameObject _shootingSter; 
    public Rigidbody2D _planetBody;
    bool _gravitFlag = false;
    // Use this for initialization
    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
        
       if(Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(-0.1f,0,0);
        }

        if (_gravitFlag == true && GameObject.Find("star").GetComponent<Revolution>()._collisionFlag == false)
        {
            UniversalGravit();
        }
    } 
    void UniversalGravit()
    {
        Vector3 vec_direction = gameObject.transform.position - _shootingSter.transform.position;
        //万有引力の計算
        Vector3 Univ_gravity = _UniversalGravity * vec_direction.normalized * (_planetBody.mass * _shootingSterBody.mass) / (vec_direction.sqrMagnitude);
        //流れ星に万有引力を掛ける
        _shootingSterBody.AddForce(Univ_gravity);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "star")
        {
            _gravitFlag = true;
        }
    }

}
