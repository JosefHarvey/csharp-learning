Order order1 = new Order(new CashPayment(), new EmailNotification());
Order order2 = new Order(new CreditPayment(), new SmsNotification());
Order order3 = new Order(new EwalletPayment(), new WhatsappNotification());

order1.Checkout();
order2.Checkout();
order3.Checkout();