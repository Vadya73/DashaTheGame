using System;
using TMPro;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

namespace CodeBase
{
    public class PlaySoundOnClick : MonoBehaviour
    {
        [SerializeField] private AudioSource _source;
        [SerializeField] private AudioClip[] _clips;
        [SerializeField] private bool _playRandomClip;

        private void OnMouseDown()
        {
            if (_source.isPlaying || _clips.Length == 0) return;
            if (_playRandomClip) PlayRandomClip();
            
            _source.PlayOneShot(_clips[0]);
        }

        private void PlayRandomClip()
        {
            var rand = Random.Range(0, _clips.Length + 1);
            for (var i = 0; i < _clips.Length; i++)
            {
                if (rand == i) _source.PlayOneShot(_clips[i]);
            }
            
        }
    }
}