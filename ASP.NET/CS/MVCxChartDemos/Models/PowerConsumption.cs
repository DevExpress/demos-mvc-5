using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos.Charts {
    public class PowerConsumptionProvider {
        public class PowerConsumption {
            string branch;
            DateTime time;
            double power;

            public string Branch { get { return branch; } }
            public DateTime Time { get { return time; } }
            public double Power { get { return power; } }

            public PowerConsumption(string branch, DateTime time, double power) {
                this.branch = branch;
                this.time = time;
                this.power = power;
            }
        }

        public static List<PowerConsumption> GetData() {
            return new List<PowerConsumption>() {
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 7, 0, 0), 429),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 8, 0, 0), 432),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 9, 0, 0), 301),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 10, 0, 0), 307),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 11, 0, 0), 310),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 12, 0, 0), 380),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 13, 0, 0), 384),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 14, 0, 0), 398),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 15, 0, 0), 379),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 16, 0, 0), 220),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 17, 0, 0), 321),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 18, 0, 0), 341),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 19, 0, 0), 368),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 20, 0, 0), 557),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 21, 0, 0), 523),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 22, 0, 0), 501),
                new PowerConsumption("Branch \"Center\"", new DateTime(1, 1, 1, 23, 0, 0), 443),

                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 7, 0, 0), 260),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 8, 0, 0), 287),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 9, 0, 0), 285),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 10, 0, 0), 281),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 11, 0, 0), 294),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 12, 0, 0), 303),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 13, 0, 0), 325),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 14, 0, 0), 336),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 15, 0, 0), 325),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 16, 0, 0), 186),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 17, 0, 0), 420),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 18, 0, 0), 455),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 19, 0, 0), 481),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 20, 0, 0), 487),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 21, 0, 0), 490),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 22, 0, 0), 467),
                new PowerConsumption("Branch \"East\"", new DateTime(1, 1, 1, 23, 0, 0), 409)
            };
        }
    }
}
