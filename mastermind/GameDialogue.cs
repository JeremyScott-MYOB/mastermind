using System;
using System.Collections.Generic;
using System.Linq;

namespace mastermind
{
    public class GameDialogue
    {
        private IConsole _console;
        private Validator _validator;

        public GameDialogue(IConsole console)
        {
            _console = console;
            _validator = new Validator();
        }
        
        public List<Colour> GetPlayersColourGuess()
        {
            var playerInput = GetPlayerColourInput();

            while (_validator.ThereAreNotFourEntries(playerInput))
            {
                PrintErrorMessage(Constants.Error_Message_Invalid_Guess_Length);
                playerInput = GetPlayerColourInput();
            }

            while (_validator.AnyColourIsInvalidInInput(playerInput))
            {
                PrintErrorMessage(Constants.Error_Message_Invalid_Colour);
                playerInput = GetPlayerColourInput();
            }
            
            var colourEnumList = playerInput
                .Split(',').Select(color => (Colour)Enum.Parse(typeof(Colour), color)).ToList();
            
            return colourEnumList;
        }

        private string GetPlayerColourInput(){
            Print_Player_Instructions();
            return _console.ReadLine().ToUpper();
        }

        private void PrintErrorMessage(string errorMessage){
            _console.WriteLine(errorMessage);
        }
        
        public void Print_Player_Instructions()
        {
            _console.WriteLine("Please enter your guess of four colours for mastermind separated by comma (i.e. Red, Orange, Yellow, Orange)");
        }
        
        public string PrintHintArray()
        {
            //obtain hint array from Mastermind
            return " ";
        }
    }
}