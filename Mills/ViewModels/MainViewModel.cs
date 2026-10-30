using Mills.Communication;
using Mills.Views;
using System.Windows.Input;
using System;

namespace Mills.ViewModels
{
    public class MainViewModel
    {
        private BoardControl boardControl;

        public MainViewModel(BoardControl boardControl)
        {
            this.boardControl = boardControl;
        }

        RelayCommand twoPlayerCommand;
        public ICommand StartTwoPlayerGameCommand
        {
            get
            {
                if (twoPlayerCommand == null)
                {
                    twoPlayerCommand = new RelayCommand(param => StartTwoPlayerGame(),
                        param => CanStartTwoPlayerGame());
                }
                return twoPlayerCommand;
            }
        }
        public bool CanStartTwoPlayerGame()
        {
            return true;
        }

        private void StartTwoPlayerGame()
        {
            boardControl.InitializeBoard();
        }
    }
}
