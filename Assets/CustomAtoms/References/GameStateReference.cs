using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `GameState`. Inherits from `AtomReference&lt;GameState, GameStatePair, GameStateConstant, GameStateVariable, GameStateEvent, GameStatePairEvent, GameStateGameStateFunction, GameStateVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameStateReference : AtomReference<
        GameState,
        GameStatePair,
        GameStateConstant,
        GameStateVariable,
        GameStateEvent,
        GameStatePairEvent,
        GameStateGameStateFunction,
        GameStateVariableInstancer>, IEquatable<GameStateReference>
    {
        public GameStateReference() : base() { }
        public GameStateReference(GameState value) : base(value) { }
        public bool Equals(GameStateReference other) { return base.Equals(other); }
        protected override bool ValueEquals(GameState other)
        {
            throw new NotImplementedException();
        }
    }
}
