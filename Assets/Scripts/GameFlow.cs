﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    private static GameFlow m_Instance;

    [SerializeField] private UIHandler m_UIHandler;

    [Header("Gameplay Elements")]
    [SerializeField] private CharacterController m_CharacterController;
    [SerializeField] private Grid m_Grid;
    [SerializeField] private InteractableTilemap m_InteractableTilemap;

    [SerializeField] private Transform m_FloatingResourcesParent;

    private bool m_IsPaused = false;

    public static GameFlow Instance
    {
        get
        {
            return m_Instance;
        }
    }

    public bool IsPaused
    {
        get
        {
            return m_IsPaused;
        }
    }

    public Grid Grid
    {
        get
        {
            return m_Grid;
        }
    }

    public InteractableTilemap InteractableTilemap
    {
        get
        {
            return m_InteractableTilemap;
        }
    }

    public Transform FloatingResourcesParent
    {
        get
        {
            return m_FloatingResourcesParent;
        }
    }

    void Awake()
    {
        if (m_Instance != null && m_Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            m_Instance = this;
        }
        // show main menu first
        m_Instance.ShowMainMenu();
    }

    public void PlayGame(bool resumed = false)
    {
        // initialize gameplay elements
        if (!resumed)
        {
            m_CharacterController.Initialize();
            m_InteractableTilemap.Initialize();
        }
        m_IsPaused = false;
        m_UIHandler.ToggleMenuUI(false);
    }

    public void PauseGame()
    {
        m_IsPaused = true;
        m_UIHandler.ToggleMenuUI(true);
        m_UIHandler.ShowMenu(GameConstants.PAUSE_MENU_SCENE_NAME);
    }

    public void ShowMainMenu()
    {
        m_IsPaused = true;
        m_UIHandler.ToggleMenuUI(true);
        m_UIHandler.ShowMenu(GameConstants.MAIN_MENU_SCENE_NAME);
    }

    public void ShowGameOver()
    {
        m_IsPaused = true;
        m_UIHandler.ToggleMenuUI(true);
        m_UIHandler.ShowMenu(GameConstants.GAME_OVER_MENU_SCENE_NAME);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}