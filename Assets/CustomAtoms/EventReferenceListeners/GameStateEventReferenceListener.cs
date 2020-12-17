using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `GameState`. Inherits from `AtomEventReferenceListener&lt;GameState, GameStateEvent, GameStateEventReference, GameStateUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/GameState Event Reference Listener")]
    public sealed class GameStateEventReferenceListener : AtomEventReferenceListener<
        GameState,
        GameStateEvent,
        GameStateEventReference,
        GameStateUnityEvent>
    { }
}
