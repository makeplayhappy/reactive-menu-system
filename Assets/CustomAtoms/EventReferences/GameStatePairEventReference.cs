using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `GameStatePair`. Inherits from `AtomEventReference&lt;GameStatePair, GameStateVariable, GameStatePairEvent, GameStateVariableInstancer, GameStatePairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameStatePairEventReference : AtomEventReference<
        GameStatePair,
        GameStateVariable,
        GameStatePairEvent,
        GameStateVariableInstancer,
        GameStatePairEventInstancer>, IGetEvent 
    { }
}
