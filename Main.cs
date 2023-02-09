using ReadEmail;

var email = new Email("outlook.office365.com", "<email>", "<senha do email>");

await email.Connect();

var message = email.GetMimeMessages();

//Console.ReadLine();
