using System.Collections.Generic;
using GameServerCore.Content;
using GameServerCore.Domain;

namespace GameServerCore.Maps
{
    public interface IMap: IUpdate
    {
        //通知事件列表
        List<IAnnounce> AnnouncerEvents { get; }
        //寻路网格
        INavGrid NavGrid { get; }
        //ID
        int Id { get; }
        //碰撞处理器
        ICollisionHandler CollisionHandler { get; }
        //初始化
        void Init();
        //地图属性
        IMapProperties MapProperties { get; }
        IMapProperties GetMapProperties(int mapId);
    }
}
