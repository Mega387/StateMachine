using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LightState : PlayerState
{
    private GameObject highlightEffect;
    private bool isActive = false;

    public LightState(PlayerControler player, TextMeshProUGUI textU, GameObject highlightEffect)
        : base(player, textU)
    {
        this.highlightEffect = highlightEffect;
    }

    public override void Enter()
    {
        if (highlightEffect == null) return;

        isActive = !isActive;
        highlightEffect.SetActive(isActive);
        textU.text = isActive ? "��������� ���" : "��������� ����";
    }

    public override void Exit()
    {
        highlightEffect.SetActive(false);
    }

    public override void Update() { }

}