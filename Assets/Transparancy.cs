using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Transparency : PlayerState
{
    private SpriteRenderer spriteRenderer;
    private bool isTransparent = false;

    public Transparency(PlayerControler player, TextMeshProUGUI textU)
        : base(player, textU)
    {
        spriteRenderer = player.GetComponent<SpriteRenderer>();
    }

    public override void Enter()
    {
        if (spriteRenderer == null) return;

        isTransparent = !isTransparent;
        spriteRenderer.color = new Color(1f, 1f, 1f, isTransparent ? 0.5f : 1f);
        textU.text = isTransparent ? "Прозрачность ВКЛ" : "Прозрачность ВЫКЛ";
    }

    public override void Exit()
    {
        spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
    }

    public override void Update() { }
}