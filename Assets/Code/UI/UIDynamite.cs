﻿using UnityEngine;
using Zenject;

namespace Code
{
    public class UIDynamite : MonoBehaviour 
    {
        public class Factory : PlaceholderFactory<UIDynamite>
        {
        }
    }
}
