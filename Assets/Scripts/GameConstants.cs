﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConstants
{
    public const string MAIN_MENU_SCENE_NAME = "MainMenu";
    public const string PAUSE_MENU_SCENE_NAME = "PauseMenu";
    public const string GAME_OVER_MENU_SCENE_NAME = "GameOverMenu";

    public const string DEFAULT_RESOURCE_PREFAB_PATH = "Prefabs/CraftingResources/DefaultResource";

    public const string PLAYER_PICKUP_COLLIDER_TAG = "PlayerPickUp";
    public const string PLAYER_TAG = "Player";


    public enum eResourceType
    {
        DEFAULT = 0
    }
}