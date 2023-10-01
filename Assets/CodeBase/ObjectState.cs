using System;
using UnityEngine;

namespace CodeBase
{
    [Serializable]
    public class ObjectState
    {
        public string StateName;
        public GameObject GameObjectState;
        public Collider2D Collider;

        public void EnterState()
        {
            GameObjectState.gameObject.SetActive(true);
            Collider.enabled = true;
        }
        
        public void ExitState()
        {
            GameObjectState.gameObject.SetActive(false);
            Collider.enabled = false;
        }
    }
}