
    public class GameResponse
    {
        private bool win;
        private bool lost;
        private string computerAnswer;
        private string userInput;
        private string message;
        private bool isValid;
        private string devInfo;
        private string errorMessage;

        public GameResponse()
        {
            win = false;
            lost = false;
            isValid = false;
        }

        internal void SetIsValid(bool isValid)
        {
            this.isValid = isValid;
        }

        internal void SetUserInput(string input)
        {
            this.userInput = input;
        }

        internal void SetComputerAnswer(string computerAnswer)
        {
            this.computerAnswer = computerAnswer;
        }

        internal void SetMessage(string message)
        {
            this.message = message;
        }

        internal void SetWin(bool win)
        {
            this.win = win;
        }

        internal void SetLost(bool lost)
        {
            this.lost = lost;
        }

        internal void SetDevInfo(string devInfo)
        {
            this.devInfo = devInfo;
        }

        internal void SetErrorMessage(string errorMessage)
        {
            this.errorMessage = errorMessage;
        }


        public string GetMessage()
        {
            return message + errorMessage;
        }
        public string GetErrorMessage()
        {
            return errorMessage;
        }

        public string GetDevInfo()
        {
            return devInfo;
        }
        public bool GetIsValid()
        {
            return isValid;
        }
    }
