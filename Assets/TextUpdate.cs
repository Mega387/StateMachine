using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextUpdate : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI stateText;

    public void UpdateStateText(string newState)
    {
        stateText.text = "���������: " + newState;
    }
    private void Start()
    {
        UpdateStateText("����");
    }
}