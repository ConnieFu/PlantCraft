﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBase : PlayerInteractableBase
{
    [SerializeField] private TextMesh m_Text;

    public override void Initialize()
    {
        base.Initialize();
        UpdateText();
    }

    public override void Reset()
    {
        base.Reset();
        UpdateText();
    }

    public override void OnEnemyHit()
    {
        m_CurrentHits++;
        UpdateText();

        if (m_CurrentHits >= m_NumberHits)
        {
            // GAME OVER
            GameFlow.Instance.ShowGameOver();
        }
    }

    private void UpdateText()
    {
        m_Text.text = (m_NumberHits - m_CurrentHits).ToString();
    }
}
