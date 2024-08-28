using System;
using System.Web.UI;

namespace OldWebFormsApp
{
    public partial class Contact : Page
    {
        protected string AddressLine1 { get; set; }
        protected string AddressLine2 { get; set; }
        protected string Phone { get; set; }
        protected string SupportEmail { get; set; }
        protected string MarketingEmail { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set the dynamic data here
                AddressLine1 = "One Microsoft Way";
                AddressLine2 = "Redmond, WA 98052-6399";
                Phone = "425.555.0100";
                SupportEmail = "Support@example.com";
                MarketingEmail = "Marketing@example.com";
            }
        }
    }
}