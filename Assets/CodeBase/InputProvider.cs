using UnityEngine;

namespace CodeBase
{
    public class InputProvider : MonoBehaviour
    {
        public Camera _Camera;
        public static InputProvider instance;
        private static Vector3 internal_mouse_world_pos;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this);
            }
        }

        public static bool left_mouse_down => Input.GetMouseButtonDown(0);
        public static bool left_mouse_up => Input.GetMouseButtonUp(0);
        public static bool left_mouse => Input.GetMouseButton(0);
        public static bool right_mouse_down => Input.GetMouseButtonDown(1);
        public static Vector3 mouse_position => Input.mousePosition;
        public Vector3 mouse_world_position
        {
            get
            {
                internal_mouse_world_pos = _Camera.ScreenToWorldPoint(Input.mousePosition);
                return internal_mouse_world_pos;
            }
        }
    }
}