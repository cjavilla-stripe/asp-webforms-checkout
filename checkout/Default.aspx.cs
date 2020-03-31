checkout/Default.aspx.cs
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using Stripe;
using Stripe.Checkout;

namespace checkout
{

  public partial class Default : System.Web.UI.Page
  {
    public string sessionId = "";

    protected void Page_Load(object sender, EventArgs e)
    {
      StripeConfiguration.ApiKey = "sk_test_";
      var options = new SessionCreateOptions
      {
        SuccessUrl = "https://example.com/success",
        CancelUrl = "https://example.com/cancel",
        PaymentMethodTypes = new List<string> {
          "card",
        },
        LineItems = new List<SessionLineItemOptions> {
          new SessionLineItemOptions {
            Name = "T-shirt",
            Description = "Comfortable cotton t-shirt",
            Amount = 1500,
            Currency = "usd",
            Quantity = 2,
          },
        },
      };

      var service = new SessionService();
      Session session = service.Create(options);
      sessionId = session.Id;
    }
  }
}
