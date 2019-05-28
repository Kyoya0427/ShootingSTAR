using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmickOff : MonoBehaviour
{
    [SerializeField]
    public GameObject _revolutionObj;
    [SerializeField]
    public GameObject _gravitationObj;
    GameObject _star;
    Rigidbody2D _starRigid;
    // Start is called before the first frame update
    void Start()
    {
        _star = GameObject.FindWithTag("Star");
        _starRigid = _star.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        _starRigid.gravityScale = 1.0f;
        _revolutionObj.GetComponent<Revolution>()._collisionFlag = false;
        _gravitationObj.GetComponent<Gravitation>()._gravitFlag = false;
    }

}
