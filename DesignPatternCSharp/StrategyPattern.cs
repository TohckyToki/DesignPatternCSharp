using System;
using StrategyPattern;

namespace DesignPatternCSharp {
    class StrategyPattern {
        public static void Run() {
            var player = new Player();
            player.SetAttackBehavior(new AttackWithKatana());
            player.PerformAttack();
        }
    }
}
