using System;
using System.Collections.Generic;

namespace Exercise3
{
    internal class ContestManager
    {
        List<Contestant> _contestants = []; 

        public void DisplayAllContestant()
        {
            DisplayContestant(_contestants);
        }

        public void AddContestant(Contestant contestant)
        {
            if (_contestants == null)
            {
                _contestants = [contestant];  // Collection expression
            }
            this._contestants.Add(contestant);
        }

        public void SearchById(int id)
        {
            DisplayContestant(this._contestants.FindAll(contestant => contestant.Id == id));
        }

        void DisplayContestant(List<Contestant> contestants)
        {
            contestants.ForEach(contestant => {
                Console.WriteLine(contestant.ToString());
            });
        }

    }
}
