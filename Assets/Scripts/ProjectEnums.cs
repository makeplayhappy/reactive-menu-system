/* Project Enums */

//public enum MyEnum : byte, IEquatable<MyEnum> {}
public enum GameState : byte{
    GamePlay,
    MainMenu,
    Shopping,
    PlayerDead,
}


public enum Difficulty{
    Simple,
    Easy,
    Medium,
    Hard
}