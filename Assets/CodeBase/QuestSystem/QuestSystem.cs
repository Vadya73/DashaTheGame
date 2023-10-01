using System.Collections.Generic;
using UnityEngine;

namespace CodeBase.QuestSystem
{
    public class QuestSystem : MonoBehaviour
    {
        [SerializeField] private List<Quest> _quests;

        public void CreateQuest(Quest quest)
        {
            _quests.Add(quest);
        }

        public void CompleteQuest(Quest quest)
        {
            
        }
    }
}