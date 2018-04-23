using OpenTok;
using System;
using System.Diagnostics;
using System.Windows;

namespace BasicVideoChat
{
    public partial class MainWindow : Window
    {
        public const string API_KEY = "100";
        public const string SESSION_ID = "1_MX4xMDB-fjE1MjQ1MDgxNDkzNTZ-WkZldjNMdkprVno0aW1uU3JxQlovNzlJfn4"; 
        public const string TOKEN = "T1==cGFydG5lcl9pZD0xMDAmc2RrX3ZlcnNpb249dGJwaHAtdjAuOTEuMjAxMS0wNy0wNSZzaWc9YzU0MDBhYmI2MTAxNzI4MTg1ODUyNTY0NTVjMDQxMTQyZDAxZDQwMjpzZXNzaW9uX2lkPTFfTVg0eE1EQi1makUxTWpRMU1EZ3hORGt6TlRaLVdrWmxkak5NZGtwclZubzBhVzF1VTNKeFFsb3ZOemxKZm40JmNyZWF0ZV90aW1lPTE1MjQ1MDgxNDkmcm9sZT1tb2RlcmF0b3Imbm9uY2U9MTUyNDUwODE0OS40MDUyMTkzNjY1Mjk5JmV4cGlyZV90aW1lPTE1MjcxMDAxNDk=";

        Session Session;
        Publisher Publisher;

        public MainWindow()
        {
            InitializeComponent();

            Publisher = new Publisher(Context.Instance, renderer: PublisherVideo);

            Session = new Session(Context.Instance, API_KEY, SESSION_ID);
            Session.Connected += Session_Connected;
            Session.Disconnected += Session_Disconnected;
            Session.Error += Session_Error;
            Session.StreamReceived += Session_StreamReceived;
            Session.Connect(TOKEN);
        }

        private void Session_Connected(object sender, System.EventArgs e)
        {
            Session.Publish(Publisher);
        }
 
        private void Session_Disconnected(object sender, System.EventArgs e)
        {
            Trace.WriteLine("Session disconnected.");
        }

        private void Session_Error(object sender, Session.ErrorEventArgs e)
        {
            Trace.WriteLine("Session error:" + e.ErrorCode);
        }

        private void Session_StreamReceived(object sender, Session.StreamEventArgs e)
        {
            Subscriber subscriber = new Subscriber(Context.Instance, e.Stream, SubscriberVideo);
            Session.Subscribe(subscriber);
        }
    }
}
