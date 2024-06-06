using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

Console.WriteLine("Hello, World!");

var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
var request = new SendMessageRequest
{
    QueueUrl = "https://sqs.sa-east-1.amazonaws.com/211125350833/teste",
    MessageBody = "Teste 123"
};

await client.SendMessageAsync(request);