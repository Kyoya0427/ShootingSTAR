using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject _gravitation;
    public Rigidbody2D _rigidStar;
    public bool _collisionFlag = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        if (_collisionFlag == true)
        {
            transform.localPosition += (transform.position - _gravitation.transform.position).normalized / 5 * Time.deltaTime;
            transform.RotateAround(_gravitation.transform.position, Vector3.back, 60 * Time.deltaTime);

        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
       _rigidStar.velocity = Vector3.zero;
        _collisionFlag = true;

    }
}
