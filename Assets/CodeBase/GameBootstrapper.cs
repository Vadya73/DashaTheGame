using UnityEngine;

namespace CodeBase
{
    public class GameBootstrapper : MonoBehaviour
    {
        [SerializeField] private Curtain _curtainPrefab;
        [SerializeField] private GameObject _UIPrefab;
        private void Awake()
        {
            Instantiate(_curtainPrefab);
            Instantiate(_UIPrefab);
        }
    }
}