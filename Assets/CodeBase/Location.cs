using UnityEngine;

namespace CodeBase
{
    public class Location : MonoBehaviour
    {
        public void Enter()
        {
            Curtain.I.Show();
            gameObject.SetActive(true);
        }

        public void Exit()
        {
            Curtain.I.Hide();
            gameObject.SetActive(false);
        }
    }
}