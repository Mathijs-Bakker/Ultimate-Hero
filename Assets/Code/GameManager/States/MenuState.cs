﻿using UnityEngine;
using Zenject;

namespace Code
{
    public class MenuState : GameStateEntity
    {
        // Debug Methods:
        public override void Initialize()
        {
            Debug.Log("MenuState: Initialized");
        }
        
        public override void Start()
        {
            Debug.Log("MenuState: Started");
        }

        public override void Tick()
        {
        }
        
        public override void Dispose()
        {
            Debug.Log("MenuState: Disposed");
        }
       
        public class Factory : Factory<MenuState>
        {
        }
    }
}