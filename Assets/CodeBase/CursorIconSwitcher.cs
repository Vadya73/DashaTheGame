using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CodeBase
{
    [DisallowMultipleComponent]
    public class CursorIconSwitcher : MonoBehaviour
    {
        private IInteractable _interactable;
        private Collider2D _collider;

        private void Awake()
        {
            _collider = GetComponent<Collider2D>();

            _interactable = GetComponent<IInteractable>();
        }

        private void Update()
        {
            if (_collider == null && EventSystem.current.IsPointerOverGameObject() && PointerIsOverUI(InputProvider.mouse_position, gameObject))
                SetMouseOver();
        }

        private void OnMouseOver() => 
            SetMouseOver();

        private void OnMouseExit() => 
            Cursor.SetCursor(Cursors.I.DefaultCursor, new Vector2(8, 2), CursorMode.Auto);

        private static bool PointerIsOverUI(Vector2 screenPos, GameObject GO)
        {
            var hitObject = UIRaycast(ScreenPosToPointerData(screenPos));
            return hitObject != null && hitObject == GO;
        }
     
        private static GameObject UIRaycast(PointerEventData pointerData)
        {
            var results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);
            return results.Count < 1 ? null : results[0].gameObject;
        }
     
        private static PointerEventData ScreenPosToPointerData(Vector2 screenPos)
            => new(EventSystem.current) { position = screenPos };

        private void SetMouseOver()
        {
            Cursor.SetCursor(Cursors.I.InteractCursor, new Vector2(8,2), CursorMode.Auto);
            if(_interactable == null || _interactable.can_interact) {} else return;
        }
    }
}