using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `GameState`. Inherits from `AtomEvent&lt;GameState&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/GameState", fileName = "GameStateEvent")]
    public sealed class GameStateEvent : AtomEvent<GameState>
    {
    }
}
