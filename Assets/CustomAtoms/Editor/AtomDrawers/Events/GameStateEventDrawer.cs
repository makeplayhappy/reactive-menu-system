#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `GameState`. Inherits from `AtomDrawer&lt;GameStateEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameStateEvent))]
    public class GameStateEventDrawer : AtomDrawer<GameStateEvent> { }
}
#endif
