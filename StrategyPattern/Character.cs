using System;

namespace StrategyPattern {
    public abstract class Character {
        protected AttackBehavior attackBehavior;

        public string Name { get; set; }
        public short Level { get; set; }

        public void PerformAttack() {
            attackBehavior.Attack();
        }
    }
}
