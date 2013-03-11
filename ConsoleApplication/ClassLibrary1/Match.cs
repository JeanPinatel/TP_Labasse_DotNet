using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public  class Match
    {
        private Club home, away;
        private int homeGoal, awayGoal;

        public Match(Club home, Club away, int homeGoal, int awayGoal) 
            {
            this.home=home;
            this.away=away;
            this.homeGoal=homeGoal;
            this.awayGoal=awayGoal;
            }


        public Club Away 
        { 
            get 
            {
                return this.away; 
            }
        }

        public int AwayGoals 
        { 
            get 
            {
                return this.awayGoal;
            } 
        }
        
        public Club Home 
        { 
            get 
            {
                return this.Home;
            } 
        }

        public int HomeGoal 
        {
            get 
            { 
                return this.homeGoal; 
            } 
        }

        public bool IsAwayForfait
        {
            get
            {

                if (this.awayGoal == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        public bool IsDraw
        {
            get
            {
                
                if (this.awayGoal == this.homeGoal) 
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }

        public bool IsHomeForfait
        {
            get
            {
                if (this.homeGoal == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }



    }
}
