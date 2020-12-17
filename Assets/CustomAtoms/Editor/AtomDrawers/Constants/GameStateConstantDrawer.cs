#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `GameState`. Inherits from `AtomDrawer&lt;GameStateConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameStateConstant))]
    public class GameStateConstantDrawer : VariableDrawer<GameStateConstant> { }
}
#endif
