#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `GameStatePair`. Inherits from `AtomEventEditor&lt;GameStatePair, GameStatePairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(GameStatePairEvent))]
    public sealed class GameStatePairEventEditor : AtomEventEditor<GameStatePair, GameStatePairEvent> { }
}
#endif
