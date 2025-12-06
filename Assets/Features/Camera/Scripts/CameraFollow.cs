using UnityEngine;

namespace Features.Camera.Scripts
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;
        public float smoothSpeed = 5f;
        public Vector3 offset = new Vector3(0, 20, -20);

        void LateUpdate()
        {
            if (target == null) return;

            Vector3 desiredPosition = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

            // If camera is orthographic and has fixed rotation, do NOT rotate here.
        }
    }
}