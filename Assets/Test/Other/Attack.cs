using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAttack : MonoBehaviour
{

    public bool _laserHit = false;

    [SerializeField]
    private float _speed = 10.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //move up @10 speed
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        //if position on y of laser greater tha or equal to 5.5, then destroy the laser
        if (transform.position.y > 10.5)
        {
            if (transform.parent != null)
            {
                Destroy(transform.parent);
            }
            Destroy(this.gameObject);
        }


    }





}
