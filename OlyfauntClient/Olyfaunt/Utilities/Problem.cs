using System;

namespace Olyfaunt
{
    /// <summary>
    /// Problem being reported, along with string that is the name of user's saved image
    /// </summary>
    public class Problem
    {
        private User reportingUser;
        private string problemImage;

        public User ReportingUser
        {
            get { return reportingUser; }
        }
        public string ProblemImage
        {
            get { return problemImage; }
        }


        public Problem(User reportingUser, string problemImage)
        {
            this.reportingUser = reportingUser;
            this.problemImage = problemImage;
        }
    }
}

