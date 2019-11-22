using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern {
    public class AttackNoWay : AttackBehavior {
        public void Attack() {
            Console.WriteLine("Can not attack.");
        }
    }
}
