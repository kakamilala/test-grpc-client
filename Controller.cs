using Grpc.Net.Client;

namespace GrpcClient
{
    public class Controller
    {
        public async Task<UserReply> GetUserData(User user)
        {
            var httpHandler = new HttpClientHandler();
            httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            
            //url grpcServer
            using var channel = GrpcChannel.ForAddress("", new GrpcChannelOptions { HttpHandler = httpHandler }); 

            var client = new UserService.UserServiceClient(channel);
            
            var reply = await client.GetUserAsync(new GetUserRequest { Phone = user.Phone, Pass = user.Pass });
            
            return reply;
        }
    }
}
