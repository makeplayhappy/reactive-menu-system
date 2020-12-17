using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `GameState`. Inherits from `UnityEvent&lt;GameState&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameStateUnityEvent : UnityEvent<GameState> { }
}
