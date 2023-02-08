using ReadEmail;

var email = new Email("outlook.office365.com", "SinFTEteste@outlook.com", "teste@fte@");

await email.Connect();

var message = email.GetMimeMessages();

//Console.ReadLine();