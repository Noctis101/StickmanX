using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAttack : MonoBehaviour {


    public float speed = 10f;
    public float range = 100f;
    public LayerMask whatToHit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
		
	}

    void ShootRay(Vector2 origin, Vector2 direction)
    {
        RaycastHit2D hit = Physics2D.Raycast(origin, direction, range, whatToHit);
        if(hit.collider != null)
        {
            Debug.Log("We have hit something");
        }
    }
}

