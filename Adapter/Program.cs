using Adapter.Adapters;
using Adapter;

INotificationSender emailSender = new EmailNotificationSender();
emailSender.Send("Hello Email!");

INotificationSender smsSender = new SmsNotificationAdapter();
smsSender.Send("Hello SMS!");

INotificationSender slackSender = new SlackNotificationAdapter();
slackSender.Send("Hello Slack!");