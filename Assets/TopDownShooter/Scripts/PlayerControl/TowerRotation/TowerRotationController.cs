using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;

namespace TopDownShooter.PlayerControls
{
    public class TowerRotationController : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        [SerializeField] private Transform _towerTransform;
        [SerializeField] private TowerRotatitonSettings _towerRotatitonSettings;

        private void Update()
        {
            _towerTransform.Rotate(0, _inputData.Horizontal * _towerRotatitonSettings.TowerRotationSpeed, 0, Space.Self);
        }

    }
}
