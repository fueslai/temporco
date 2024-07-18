public static void SubscribeToSubject(NatsConnection connection, string subject)
{
    var subscription = connection.SubscribeAsync<string>(subject, message =>
    {
        Console.WriteLine($"Received message '{message}' on subject '{subject}'");
        return Task.CompletedTask;
    });

    Console.WriteLine($"Subscribed to subject '{subject}'");
}
