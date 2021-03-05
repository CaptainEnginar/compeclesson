using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerControls
{
    [CreateAssetMenu(menuName = "Topdown Shooter/Player/Player Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float HorizantalSpeed = 0.25f;
        public float VerticalSpeed = 0.25f;

    }
}
