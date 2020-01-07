namespace GameServerCore.Enums
{
    //语音提示枚举
    public enum Announces : byte
    {
        WELCOME_TO_SR = 0x77,      //欢迎来到召唤师峡谷
        THIRY_SECONDS_TO_MINIONS_SPAWN = 0x78,  //30秒出兵
        MINIONS_HAVE_SPAWNED = 0x7F,
        MINIONS_HAVE_SPAWNED2 = 0x76
    }
}