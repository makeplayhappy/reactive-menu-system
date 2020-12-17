using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `GameState`. Inherits from `AtomValueList&lt;GameState, GameStateEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/GameState", fileName = "GameStateValueList")]
    public sealed class GameStateValueList : AtomValueList<GameState, GameStateEvent> { }
}
