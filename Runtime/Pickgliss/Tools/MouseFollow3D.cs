using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Pickgliss.Tools
{
    public class MouseFollow3D : MonoBehaviour
    {
        protected Camera mainCamera;
        public InputAction holdAction;
        protected Vector3 velocity = Vector3.zero;
        public float mouseDragSpeed = .1f;
        private void Awake()
        {
            mainCamera = Camera.main;
        }

        private void OnDisable()
        {
            holdAction.performed -= ActionPerformed;
            holdAction.Disable();
        }

        private void OnEnable()
        {
            holdAction.Enable();
            holdAction.performed += ActionPerformed;
        }

        protected virtual void ActionPerformed(InputAction.CallbackContext callbackContext)
        {
            StartCoroutine(DragUpdate());
        }

        private IEnumerator DragUpdate()
        {
            var initialDistance = Vector3.Distance(transform.position, mainCamera.transform.position);
            while (holdAction.ReadValue<float>() != 0)
            {
                var ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
                var position = transform.position;
                
                transform.position =
                    Vector3.SmoothDamp(position, ray.GetPoint(initialDistance), ref velocity, mouseDragSpeed);
                yield return null;
            }
        }
    }
}