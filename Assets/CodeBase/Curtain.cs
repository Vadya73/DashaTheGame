using System.Collections;
using UnityEngine;

namespace CodeBase
{
    public class Curtain : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _curtain;

        public static Curtain I;

        private void Awake()
        {
            if (I == null) I = this;
            else if (I == this) Destroy(gameObject);
            
            Hide();
        }

        public void Show()
        {
            gameObject.SetActive(true);
            _curtain.alpha = 1;
        }

        public void Hide() => StartCoroutine(DoFadeIn());

        private IEnumerator DoFadeIn()
        {
            while (_curtain.alpha >= 0)
            {
                _curtain.alpha -= 0.03f;
                yield return new WaitForSeconds(0.03f);
            }
            
            gameObject.SetActive(true);
        }
    }
}