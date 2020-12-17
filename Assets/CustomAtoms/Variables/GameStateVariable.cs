using UnityEngine;
using System;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `GameState`. Inherits from `AtomVariable&lt;GameState, GameStatePair, GameStateEvent, GameStatePairEvent, GameStateGameStateFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/GameState", fileName = "GameStateVariable")]
    public sealed class GameStateVariable : AtomVariable<GameState, GameStatePair, GameStateEvent, GameStatePairEvent, GameStateGameStateFunction>
    {
        protected override bool ValueEquals(GameState other)
        {
            //throw new NotImplementedException();
            return (this.Value == null && other == null) || this.Value != null && other != null && this.Value == other;
        }
    }
}
