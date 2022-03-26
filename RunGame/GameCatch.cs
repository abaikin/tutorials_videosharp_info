using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunGame
{
    class GameCatch
    {
        public List<Игрок> gamers {  get; private  set; }
        Игрок leader;

        int leaderSkipSteps;
        static int MaxSkipSteps = 10;

        public GameCatch()
        {
            gamers = new List<Игрок>();
            leader = null;
        }

        /* Any object that has interface gamer */
        public void addGamer(Игрок gamer){

            gamers.Add(gamer);
            SetNewLeader(gamer);

        }
        public void Step()
        {
            RunAll();
            FindNewLeader();
        }

        private void RunAll(){
            foreach (Игрок g in gamers)
            {
                if(!leader.Equals(g) || leaderSkipSteps == 0)
                    g.Бежать();
            }
        }
        private void SetNewLeader(Игрок gamer)
        {
            if (leader != null)
            {
                leader.НеГоля();
            }
            
            leader = gamer;
            if (leader != null)
            {
                leader.Голя();
            }
            leaderSkipSteps = MaxSkipSteps;
                
        }

        private void FindNewLeader()
        {

            if (leader == null)
                return;

            if (leaderSkipSteps > 0)
            {
                leaderSkipSteps--;
                return;
            }

 	        foreach(Игрок g in gamers ){
                if(!leader.Equals(g))
                if(leader.Поймал(g)){
                    SetNewLeader(g);
                    return;
                }
            }

        }



    }
}
