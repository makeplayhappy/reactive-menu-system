using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `GameStatePair`. Inherits from `AtomEventInstancer&lt;GameStatePair, GameStatePairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/GameStatePair Event Instancer")]
    public class GameStatePairEventInstancer : AtomEventInstancer<GameStatePair, GameStatePairEvent> { }
}
