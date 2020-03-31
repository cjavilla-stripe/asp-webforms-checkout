<%@ Page Language="C#" Inherits="checkout.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
<title>Default</title>
</head>
<body>
<form id="form1" runat="server">
<button type="submit">Checkout</button>
</form>
<script src="https://js.stripe.com/v3/"></script>

<script>
var stripe = Stripe('pk_test_vAZ3gh1LcuM7fW4rKNvqafgB00DR9RKOjN');

var form = document.getElementById('form1');
form.addEventListener('submit', function(e) {
    e.preventDefault();
    stripe.redirectToCheckout({
sessionId: "<%= sessionId %>"
})
    })
</script>
</body>
</html>
