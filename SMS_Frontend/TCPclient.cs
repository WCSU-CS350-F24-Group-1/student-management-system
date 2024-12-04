using System;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;

public class TcpClientService
{
    private readonly string _serverAddress;
    private readonly int _serverPort;

    public TcpClientService(string serverAddress, int serverPort)
    {
        _serverAddress = serverAddress;
        _serverPort = serverPort;
    }

    public string SendRequest(string command, object data)
    {
        try
        {
            using (var client = new TcpClient(_serverAddress, _serverPort))
            using (var stream = client.GetStream())
            using (var reader = new StreamReader(stream))
            using (var writer = new StreamWriter(stream) { AutoFlush = true })
            {
                // Create request JSON
                var request = new
                {
                    Command = command,
                    Data = JsonSerializer.Serialize(data)
                };

                var requestJson = JsonSerializer.Serialize(request);
                writer.WriteLine(requestJson);

                // Read the response
                var response = reader.ReadLine();
                return response;
            }
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }
}
