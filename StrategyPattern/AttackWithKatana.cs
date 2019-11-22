using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern {
    public class AttackWithKatana : AttackBehavior {
        public void Attack() {
            Console.WriteLine("Attack with Katana.");
        }
    }
}
