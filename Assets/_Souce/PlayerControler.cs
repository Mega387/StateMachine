using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControler : MonoBehaviour
{
    private StateMachine stateMachine;

    [SerializeField] private TextMeshProUGUI textUpdate;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject highlightEffect;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        stateMachine = new StateMachine();
        spriteRenderer = GetComponent<SpriteRenderer>();

        var shootState = new Shoot(this, textUpdate, bulletPrefab, firePoint);
        var lightState = new LightState(this, textUpdate, highlightEffect);
        var transparencyState = new Transparency(this, textUpdate);

        stateMachine.Initialize(shootState);
    }

    private void Update()
    {
        stateMachine.Update();

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (stateMachine.CurrentState is Shoot)
                stateMachine.ChangeState(new LightState(this, textUpdate, highlightEffect));
            else if (stateMachine.CurrentState is LightState)
                stateMachine.ChangeState(new Transparency(this, textUpdate));
            else
                stateMachine.ChangeState(new Shoot(this, textUpdate, bulletPrefab, firePoint));
        }
    }
}