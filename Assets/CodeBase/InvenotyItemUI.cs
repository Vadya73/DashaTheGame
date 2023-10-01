using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase
{
    public class InvenotyItemUI : MonoBehaviour
    {
        [SerializeField] private Image _image;
        [SerializeField] private TextMeshProUGUI _text;

        public void UpdateInfo(Sprite imagePath, int count)
        {
            SetImage(imagePath);
            SetText(count);
        }

        private void SetImage(Sprite image)
        {
            _image.sprite = image;
        }

        private void SetText(int count) => 
            _text.text = count.ToString();
    }
}