using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerControls
{
    [CreateAssetMenu(menuName = "Topdown Shooter/Player/Tower Rotation Settings")]
    public class TowerRotatitonSettings : ScriptableObject
    {
        public float TowerRotationSpeed = 1f;
    }
}