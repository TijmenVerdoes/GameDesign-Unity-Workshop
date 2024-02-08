using System.Collections;

using UnityEngine;
using UnityEngine.InputSystem;

namespace Scenes.Adil
{
    public class TankController : MonoBehaviour
    {
        public float movementSpeed = 5f;
        public float rotationSpeed = 50f;


        private float forwardInput;
        private float rotationInput;

        private void Start()
        {
        }

        private void Update()
        {
            ProcessMovementInput();
            ProcessRotationInput();
        }

        private void FixedUpdate()
        {
        }
        


        private void ProcessMovementInput()
        {
            var input = Input.GetAxis("Vertical");
            var movement = Vector3.forward * (input * movementSpeed * Time.deltaTime);
            transform.Translate(movement);
        }

        private void ProcessRotationInput()
        {
            var input1 = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.up * (input1 * rotationSpeed * Time.deltaTime));
        }

    }
}
