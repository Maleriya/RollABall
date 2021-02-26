using System;
using UnityEngine;

namespace Assets.Scripts
{
    public sealed class CaughtPlayerEventArgs : EventArgs
    {
        public Color Color { get; }
        
        public CaughtPlayerEventArgs(Color Color)
        {
            this.Color = Color;
        }

    }

}
