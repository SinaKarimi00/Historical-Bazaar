using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Features.Player.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private InputActionReference actionReference;
        [SerializeField] private float speed;

        private void Update()
        {
            ControlMovement();
        }

        private void ControlMovement()
        {
            var input = actionReference.action.ReadValue<Vector2>();

            var move = new Vector3(input.x, 0f, input.y);

            move = move.normalized * (speed * Time.deltaTime);

            transform.Translate(move, Space.World);
        }
    }
}