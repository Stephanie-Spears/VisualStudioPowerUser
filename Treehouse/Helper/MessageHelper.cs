namespace Treehouse.Helper
{
    public class MessageHelper
    {
        private string version;

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        public string GetMessage()
        {
            var message = ExternalService.GetMessage();
            if (message.Length > 140)
            {
                // Message can't be more than 140 characters
                message = message.Substring(0, 140); 
            }
            return message;
        }
    }
}