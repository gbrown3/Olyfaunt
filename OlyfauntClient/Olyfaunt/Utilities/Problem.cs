using System;
using Xamarin.Forms;
namespace Olyfaunt
{
    /// <summary>
    /// Problem being reported, along with string that is the name of user's saved image
    /// </summary>
    public class Problem
    {
        private User reportingUser;
        private Image problemImage;

        public User ReportingUser
        {
            get { return reportingUser; }
        }
        public Image ProblemImage
        {
            get { return problemImage; }
        }


        public Problem(User reportingUser, Image problemImage)
        {
            this.reportingUser = reportingUser;
            this.problemImage = problemImage;
        }
    }
}

