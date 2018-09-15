using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    [SerializeField]
    GameObject bulletPrefab;
    [SerializeField]
    Transform weaponTip;

    public float fireRate = 5f;
    public float damage = 25f;
    public LayerMask whatToHit;
    public float range = 100f;

    float timeFire = 0;

    PlayerMovement c_movement;

    private void Awake()
    {
        c_movement = GetComponent<PlayerMovement>();
    }

    public void OnShoot()
    {
        if(fireRate == 0)
        {
            Fire();
        }
        else
        if (Time.time > timeFire)
        {
            timeFire = Time.time / fireRate;
            Fire();
        }
    }


    void Fire()
    {
        Vector2 firePos = new Vector2(weaponTip.position.x, weaponTip.position.y);
        Vector2 dir = (c_movement.m_FacingRight) ? Vector2.right : Vector2.left;

        RaycastHit2D hit = Physics2D.Raycast(firePos, dir, range, whatToHit);

        //Debug.DrawRay(firePos, dir * range, Color.blue, 1f);
        DrawBullet();
    }

    void DrawBullet()
    {
        Quaternion rot = (c_movement.m_FacingRight) ? Quaternion.Euler(0, 0, 0) : Quaternion.Euler(0, 180, 0);

        Instantiate(bulletPrefab, weaponTip.position, rot);
    }
}
