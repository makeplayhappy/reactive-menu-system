using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;GameState&gt;`. Inherits from `IPair&lt;GameState&gt;`.
    /// </summary>
    [Serializable]
    public struct GameStatePair : IPair<GameState>
    {
        public GameState Item1 { get => _item1; set => _item1 = value; }
        public GameState Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private GameState _item1;
        [SerializeField]
        private GameState _item2;

        public void Deconstruct(out GameState item1, out GameState item2) { item1 = Item1; item2 = Item2; }
    }
}