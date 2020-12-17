#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `GameState`. Inherits from `AtomDrawer&lt;GameStateValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameStateValueList))]
    public class GameStateValueListDrawer : AtomDrawer<GameStateValueList> { }
}
#endif
