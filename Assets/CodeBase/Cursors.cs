using System;
using UnityEngine;

namespace CodeBase
{
    public class Cursors : MonoBehaviour
    {
        public Texture2D DefaultCursor;
        public Texture2D InteractCursor;

        public static Cursors I = null;

        private void Awake()
        {
            if (I == null)
            {
                I = this;
            }
            else if (I == this)
            {
                Destroy(gameObject);
            }
        }
    }
}