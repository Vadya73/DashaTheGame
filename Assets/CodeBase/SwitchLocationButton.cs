using UnityEngine;

namespace CodeBase
{
    public class SwitchLocationButton : MonoBehaviour
    {
        [SerializeField] private Location _currentLocation;
        [SerializeField] private Location _toLocationSwitch;

        [SerializeField] private Sprite _curtain;

        private void OnMouseDown()
        {
            _currentLocation.Exit();
            _toLocationSwitch.Enter();
            Cursor.SetCursor(Cursors.I.DefaultCursor, new Vector2(8,2), CursorMode.Auto);
        }


    }
}