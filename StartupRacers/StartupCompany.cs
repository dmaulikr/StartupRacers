using System;

namespace StartupRacers
{
    class StartupCompany
    {
        private int morale = 95;
        private int acceleration = 100;
        private int ceoSteadiness = 0;
        private String name;
        private Boolean dnf;
        private Random fate;
        
        public int actualizeMissionStatement()
        {
            acceleration = 100;
            eventCheck();
            return acceleration;

        }
        
        private void eventCheck()
        {
            fate = new Random();
            if (fate.Next(1, 101) < 100 - morale)
            {
                acceleration -= fate.Next(11, 301);
                moraleCheck();
            }
            else if (fate.Next(1,101) < morale)
            {
                acceleration += fate.Next(5, 100);
                morale += fate.Next(5, 20);
            }
            else {
                morale += fate.Next(1, 6);
            }
            if (morale > 95)
            {
                morale = 95;
            }

        }

        private void moraleCheck()
        {
            if(ceoSteadiness == 0)
            {
                ceoSteadiness = fate.Next(5, 96);
            }
            if (fate.Next(1, 101) < 100 - ceoSteadiness)
            {
                ceoSteadiness -= 5;
                morale = morale - fate.Next(5, 21);
                if (ceoSteadiness < 0 || morale < 0)
                {
                    dnf = true;
                }
            }
            else
            {
                morale -= fate.Next(1, 6);
            }

        }
    }
}
