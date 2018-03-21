﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Code
{
    public class PlayState : GameStateEntity
    {
        public override void Initialize()
        {
            Debug.Log("GamePlayState: Initialized");
        }
        
        public override void Start()
        {
            Debug.Log("GamePlayState: Started");
            SceneManager.LoadScene(1);
        }
        
        public override void Tick()
        {
            
        }
        
        public override void Dispose()
        {
            Debug.Log("GamePlayState: Disposed");
        }


        [Serializable]
        public class Settings
        {
            
        }
        
        public class Factory : Factory<PlayState>
        {
        }
    }
}