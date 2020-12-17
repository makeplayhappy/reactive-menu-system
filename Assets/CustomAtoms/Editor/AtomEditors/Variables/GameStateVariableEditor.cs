using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `GameState`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(GameStateVariable))]
    public sealed class GameStateVariableEditor : AtomVariableEditor<GameState, GameStatePair> { }
}
