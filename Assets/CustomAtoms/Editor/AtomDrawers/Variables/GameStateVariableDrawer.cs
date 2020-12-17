#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `GameState`. Inherits from `AtomDrawer&lt;GameStateVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameStateVariable))]
    public class GameStateVariableDrawer : VariableDrawer<GameStateVariable> { }
}
#endif
