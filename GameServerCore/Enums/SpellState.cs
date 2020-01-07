namespace GameServerCore.Enums
{
    //施法状态
    public enum SpellState
    {
        STATE_READY,        //准备完毕
        STATE_CASTING,      //施法中
        STATE_COOLDOWN,     //冷却
        STATE_CHANNELING    //吟唱中
    }
}