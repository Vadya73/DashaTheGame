using UnityEngine;

namespace CodeBase
{
    [RequireComponent(typeof(Collider2D))]
    public class ChangeObjectStateComponent : MonoBehaviour
    {
        [SerializeField] private VariantToChangeState _variant;
        
        [SerializeField] private ObjectState[] _states;
        private ObjectState _currentState;
        
        [SerializeField] private Transform _transformToChange;
        private Vector3 _defaultPostion;


        private void Awake()
        {
            _defaultPostion = transform.position;
            
            if (_variant == VariantToChangeState.ChangeObjectState)
            {
                _currentState = _states[0];
                foreach (var state in _states) 
                    state.ExitState();
                
                _currentState.EnterState();
            }
        }

        private void OnMouseDown()
        {
            switch (_variant)
            {
                case VariantToChangeState.ChangeTransform:
                    TryChangeTrasformState();
                    break;
                case VariantToChangeState.ChangeObjectState:
                    TryChangeObjectState();
                    break;
                default:
                    return;
            }
        }

        private void TryChangeTrasformState()
        {
            if (_variant == VariantToChangeState.ChangeTransform)
                    transform.position = transform.position == _defaultPostion
                    ? _transformToChange.position
                    : _defaultPostion;
        }

        private void TryChangeObjectState()
        {
            if (_variant != VariantToChangeState.ChangeObjectState)
                return;
            
            for (var i = 0; i < _states.Length; i++)
            {
                if (_currentState == _states[i] && _states[i + 1] != null)
                {
                    _currentState.ExitState();
                    _currentState = _states[i + 1];
                    _currentState.EnterState();
                    
                    return;
                }

                _currentState.ExitState();
                _currentState = _states[0];
                _currentState.EnterState();
            }
        }
    }

    public enum VariantToChangeState
    {
        ChangeObjectState,
        ChangeTransform,
    }
}