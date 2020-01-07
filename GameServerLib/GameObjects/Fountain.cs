using System;
using GameServerCore.Enums;

namespace LeagueSandbox.GameServer.GameObjects
{
    //水泉
    public class Fountain
    {
        private const float PERCENT_MAX_HEALTH_HEAL = 0.15f;    //生命/魔法百分比恢复
        private const float PERCENT_MAX_MANA_HEAL = 0.15f;
        private const float HEAL_FREQUENCY = 1000f;     //1000毫秒治愈一次
        private float _x;       //位置、大小
        private float _y;
        private float _fountainSize;
        private float _healTickTimer;   //计时器
        private TeamId _team;       //队伍ID
        private Game _game;

        public Fountain(Game game, TeamId team, float x, float y, float size)
        {
            _game = game;
            _x = x;
            _y = y;
            _fountainSize = size;
            _healTickTimer = 0;
            _team = team;
        }

        internal void Update(float diff)
        {
            //计时器
            _healTickTimer += diff;
            if (_healTickTimer < HEAL_FREQUENCY)
            {
                return;
            }

            _healTickTimer = 0;

            //获取水泉范围内单位
            var champions = _game.ObjectManager.GetChampionsInRange(_x, _y, _fountainSize, true);
            foreach (var champion in champions)
            {
                //检测本方队伍
                if (champion.Team != _team)
                {
                    continue;
                }

                //加血
                var hp = champion.Stats.CurrentHealth;
                var maxHp = champion.Stats.HealthPoints.Total;
                champion.Stats.CurrentHealth = Math.Min(hp + maxHp * PERCENT_MAX_HEALTH_HEAL, maxHp);

                //加魔法：不加其他类型能量
                if ((byte)champion.Stats.ParType > 1)
                {
                    continue;
                }

                var mp = champion.Stats.CurrentMana;
                var maxMp = champion.Stats.ManaPoints.Total;
                champion.Stats.CurrentMana = Math.Min(mp + maxMp * PERCENT_MAX_MANA_HEAL, maxMp);
            }
        }
    }
}
