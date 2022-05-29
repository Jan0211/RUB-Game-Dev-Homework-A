using UnityEngine;

namespace A4.Scripts
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DataHolderScriptableObject", order = 1)]
    public class DataHolder : ScriptableObject
    {
        public int baseCostClick;
        public int baseCostStudent;
        public int baseCostScientist;

        public float multiplierClick;
        public float multiplierCharacter;
    }
}