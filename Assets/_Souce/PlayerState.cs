using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class PlayerState : MonoBehaviour
{
    protected PlayerControler player;
    protected TextMeshProUGUI textU;

    public PlayerState(PlayerControler player, TextMeshProUGUI textU)
    {
        this.player = player;
        this.textU = textU;
    }

    public abstract void Enter();
    public abstract void Exit();
    public abstract void Update();
}