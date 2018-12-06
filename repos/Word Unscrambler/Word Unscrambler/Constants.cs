using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Unscrambler
{
    class Constants
    {
        public const string WordListFileName = "wordlist.txt";

        public const string OptionsOnHowToEnterScrambledWords = "Enter scrambled word(s) manually or as a file: F - file/M - manually";
        public const string OptionsOnContinuingTheProgram = "Would you like to continue? Y/N";

        public const string EnterScrambledWordsViaFile = "Enter full path including file name: ";
        public const string EnterScrambledWordsManually = "Enter word(s) manually (separeted by commas if multiple): ";
        public const string EnterScrambledWordsOptionNotRecognized = "The option was not recognized.";

        public const string ErrorScrambledWordsCannotBeLoaded = "Scrambled words were not loaded because there was an error: ";
        public const string ErrorProgramWillBeTerminated = "The program will be terminated: ";

        public const string MatchFound = "MATCH FOUND FOR {0} : {1}";
        public const string MatchNotFound = "NO MATCHES HAVE BEEN FOUND";

        public const string Yes = "Y";
        public const string No = "N";
        public const string Manual = "M";
        public const string File = "F";
    }
}