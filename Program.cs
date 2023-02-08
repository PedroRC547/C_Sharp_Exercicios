using MailKit;
using MailKit.Net.Imap;
using MimeKit;

namespace ReadEmail
{
    public class Email
    {
        public ImapClient ImapClient;
        public string IMAP_HOST;

        public string IMAP_USER;

        public string IMAP_PASSWORD;

        private const int IMAP_PORTA = 993;

        public Email(string iMAP_HOST, string iMAP_USER, string iMAP_PASSWORD)
        {
            IMAP_HOST = iMAP_HOST;
            IMAP_USER = iMAP_USER;
            IMAP_PASSWORD = iMAP_PASSWORD;
            ImapClient = new ImapClient();

        }

        public async Task Connect()
        {
            if (!ImapClient.IsConnected)
                await ImapClient.ConnectAsync(IMAP_HOST, IMAP_PORTA, MailKit.Security.SecureSocketOptions.SslOnConnect);

            if (!ImapClient.IsAuthenticated)
            {
                await ImapClient.AuthenticateAsync(IMAP_USER, IMAP_PASSWORD);
                await ImapClient.Inbox.OpenAsync(MailKit.FolderAccess.ReadWrite);
            }
        }

        public List<MimeMessage> GetMimeMessages()
        {
            var messages = new List<MimeMessage>();
            var messagesNotRead = ImapClient.Inbox.Search(MailKit.Search.SearchQuery.NotSeen);

            foreach (var uid in messagesNotRead)
            {
                Console.WriteLine("a");
                var message = ImapClient.Inbox.GetMessage(uid);
                var messageCorpo = message.TextBody;
                var messageCorpoHtml = message.HtmlBody;
                var messageCorpoSubject = message.Subject;

                messages.Add(message);
                ImapClient.Inbox.AddFlags(uid, MessageFlags.Seen, true);

                Console.WriteLine(messageCorpo);
                Console.WriteLine(messageCorpoHtml);
                Console.WriteLine(messageCorpoSubject);
            }

            return messages;
        }
    }
}