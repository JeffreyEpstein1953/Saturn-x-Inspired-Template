using System;
using UnityEngine;

namespace StupidTemplate.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(new Color32(0, 0, 0, 255), 0f),
            new GradientColorKey(new Color32(0, 0, 0, 255), 0.45f),
            new GradientColorKey(new Color32(0, 0, 0, 255), 0.55f),
            new GradientColorKey(new Color32(166, 57, 255, 255), 1f)
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
