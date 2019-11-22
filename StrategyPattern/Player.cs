using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern {
    public class Player : Character {
        public Player() {
            this.attackBehavior = new AttackNoWay();
        }

        public void SetAttackBehavior(AttackBehavior attackBehavior) {
            this.attackBehavior = attackBehavior;
        }
    }
}
