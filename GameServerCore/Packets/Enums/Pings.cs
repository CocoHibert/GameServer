namespace GameServerCore.Packets.Enums
{
    //��Ҽ�Ping�ź�
    public enum Pings : byte
    {
        PING_DEFAULT = 0,       //Ĭ��
        PING_DANGER = 2,        //Σ��
        PING_MISSING = 3,       //��ʧ
        PING_ON_MY_WAY = 4,     //��·��
        PING_ASSIST = 6         //����Э��
    }
}