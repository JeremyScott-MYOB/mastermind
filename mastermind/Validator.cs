using System;
using System.Text.RegularExpressions;

namespace mastermind
{
    public class Validator
    {
        
        public Validator()
        {
            
        }

        public bool IsValidColourGuess(string playerResponse)// empty string, non-letters, no comma, check that there are 3 commas (4 colours), are the colour valid colours - regex 
        {
            //playerResponse = playerResponse.ToUpper(); //use () not [] for alternative colour options
            var pattern = "(RED|BLUE|GREEN|ORANGE|PURPLE|YELLOW), (RED|BLUE|GREEN|ORANGE|PURPLE|YELLOW), (RED|BLUE|GREEN|ORANGE|PURPLE|YELLOW), (RED|BLUE|GREEN|ORANGE|PURPLE|YELLOW)";
            var validPattern = new Regex(pattern);
            var stringIsNotEmpty = playerResponse != String.Empty;
            var patternIsMatch = validPattern.IsMatch(playerResponse);
            return stringIsNotEmpty && patternIsMatch;
        }
        
        public bool IsValidColour(string playerResponse)
        {
            playerResponse = playerResponse.ToUpper();
            var pattern = "(RED|BLUE|GREEN|ORANGE|PURPLE|YELLOW)";
            var validPattern = new Regex(pattern);
            var stringIsNotEmpty = playerResponse != String.Empty;
            var patternIsMatch = validPattern.IsMatch(playerResponse);
            return stringIsNotEmpty && patternIsMatch;
        }
    }
}