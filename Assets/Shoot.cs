using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shoot : PlayerState
{
    private GameObject bulletPrefab;
    private Transform firePoint;

    public Shoot(PlayerControler player, TextMeshProUGUI textU, GameObject bulletPrefab, Transform firePoint)
        : base(player, textU)
    {
        this.bulletPrefab = bulletPrefab;
        this.firePoint = firePoint;
    }

    public override void Enter()
    {
        textU.text = "Стрельба";
        FireBullet();
    }

    public override void Exit() { }

    public override void Update() { }

    private void FireBullet()
    {
        if (bulletPrefab == null || firePoint == null) return;

        GameObject bullet = GameObject.Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * 10f;
    }
}