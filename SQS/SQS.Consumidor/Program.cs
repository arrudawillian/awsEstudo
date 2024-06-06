using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

Console.WriteLine("Hello, World!");

var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
var request = new ReceiveMessageRequest
{
    QueueUrl = "https://sqs.sa-east-1.amazonaws.com/211125350833/teste"
};

while (true)
{
    var response = await client.ReceiveMessageAsync(request);

    foreach (var message in response.Messages)
    {
        Console.WriteLine(message.Body);
        await client.DeleteMessageAsync("https://sqs.sa-east-1.amazonaws.com/211125350833/teste", message.ReceiptHandle);
    }
}
