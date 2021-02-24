using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class ControlRigidBody : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private ControlRigidBodySettings _settings;
        private bool spaceKeyDown = false;

        void Update()
        {
            spaceKeyDown = Input.GetKeyDown(KeyCode.Space);
            if (spaceKeyDown)
            {
                _rigidbody.AddForce(_settings.JumpForce, ForceMode.Impulse);
            }
        }
    }
}
