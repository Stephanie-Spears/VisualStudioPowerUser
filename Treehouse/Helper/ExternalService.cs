using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Treehouse.Helper
{
    public class ExternalService
    {
        public static void UploadCommentUpTo30Chars(string comment)
        {
            if (comment.Length > 28)
            {
                throw new Exception("An error occurred");
            }
        }
        public static string ReadComment()
        {
            return "Comment";
        }
        public static string GetMessage()
        {
            return "Message";
        }
    }
}