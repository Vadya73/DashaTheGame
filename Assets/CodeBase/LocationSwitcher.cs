using System;
using UnityEngine;

namespace CodeBase
{
    public class LocationSwitcher : MonoBehaviour
    {
        [SerializeField] private Location[] _locations;

        private void Awake()
        {
            foreach (var location in _locations) 
                location.gameObject.SetActive(false);
            
            _locations[0].gameObject.SetActive(true);
        }
    }
}