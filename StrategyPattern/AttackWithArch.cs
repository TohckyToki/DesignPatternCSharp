using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern {
    public class AttackWithArch : AttackBehavior {
        public void Attack() {
            Console.WriteLine("Attack with arch.");
        }
    }
}
