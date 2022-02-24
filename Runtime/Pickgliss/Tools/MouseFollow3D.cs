using System.Collections;
using Pickgliss.Extension;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Pickgliss.Tools
{
    public class MouseFollow3D : MonoBehaviour
    {
        protected Camera mainCamera;
        public InputActionReference holdAction;
        protected Vector3 velocity = Vector3.zero;
        public float mouseDragSpeed = .1f;
        private void Awake()
        {
            mainCamera = Camera.main;
        }

        private void OnEnable()
        {
            holdAction.action.Enable();
            holdAction.action.started += startFollow;
            holdAction.action.performed += Holding;
            holdAction.action.canceled += endFollow;
        }
        
        private void OnDisable()
        {
            holdAction.action.started -= startFollow;
            holdAction.action.performed -= Holding;
            holdAction.action.canceled -= endFollow;
            holdAction.action.Disable();
        }


        protected virtual void endFollow(InputAction.CallbackContext callbackContext)
        {
            Debug.Log($"MouseFollow3D endFollow {callbackContext}");
        }

        protected virtual void startFollow(InputAction.CallbackContext callbackContext)
        {
            Debug.Log($"MouseFollow3D startFollow {callbackContext}");
            StartCoroutine(DragUpdate());
        }


        protected virtual void Holding(InputAction.CallbackContext callbackContext)
        {
            Debug.Log($"MouseFollow3D Holding {callbackContext}");
            // StartCoroutine(DragUpdate());
        }

        protected IEnumerator DragUpdate()
        {
            var initialDistance = Vector3.Distance(transform.position, mainCamera.transform.position);
            while (holdAction.action.ReadValue<float>() != 0)
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