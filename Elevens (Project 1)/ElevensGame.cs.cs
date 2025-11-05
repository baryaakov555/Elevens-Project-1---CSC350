using System;
using System.Collections.Generic;
using System.Linq;

namespace Elevens
{
    public class ElevensGame
    {
        private Deck deck;
        private List<Card> board;
        private const int boardSize = 9;

        public ElevensGame()
        {
            deck = new Deck();
            board = new List<Card>();

            for (int i = 0; i < boardSize; i++)
                board.Add(deck.Deal());
        }

        public List<Card> GetBoard() => board;

        public bool IsLegalMove(List<int> selected)
        {
            if (selected.Count == 2)
            {
                int sum = selected.Sum(i => board[i].Value);
                return sum == 11;
            }

            if (selected.Count == 3)
            {
                var ranks = selected.Select(i => board[i].Rank).ToList();
                return ranks.Contains("Jack") && ranks.Contains("Queen") && ranks.Contains("King");
            }

            return false;
        }

        public bool AnotherPlayIsPossible()
        {
            for (int i = 0; i < board.Count; i++)
                for (int j = i + 1; j < board.Count; j++)
                    if (IsLegalMove(new List<int> { i, j })) return true;

            for (int i = 0; i < board.Count; i++)
                for (int j = i + 1; j < board.Count; j++)
                    for (int k = j + 1; k < board.Count; k++)
                        if (IsLegalMove(new List<int> { i, j, k })) return true;

            return false;
        }

        public void ReplaceCards(List<int> selected)
        {
            foreach (int i in selected)
            {
                if (deck.Size() > 0)
                    board[i] = deck.Deal();
                else
                    board[i] = null;
            }
        }


        public bool GameOver()
        {
            return !AnotherPlayIsPossible() && deck.Size() == 0;
        }

    }
}
