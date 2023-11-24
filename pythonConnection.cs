using System.IO;
using UnityEngine;
using System.Net.Sockets;
using System.Text;

public class pythonConnection : MonoBehaviour
{
    //-------------------------------------------------------------
    //AREA OF PYTHON CONNECTION
    //-------------------------------------------------------------



    public string serverAddress = "localhost"; // Server address
    public int serverPort = 8080; // Server port

    private TcpClient client;
    private NetworkStream stream;

    public bool IsConnected()
    {
        try
        {
            client = new TcpClient(serverAddress, serverPort);
            // Try to send a small piece of data to check the connection
            // You can replace this with any operation that involves communication
            client.GetStream().Write(new byte[] { 0 }, 0, 1);
            return true;
        }
        catch (System.Exception e)
        {
            return false;
        }
    }

    public void ConnectToServer()
    {
        //Debug.Log("Connecting to DPROSA Server...");

        try
        {
            client = new TcpClient(serverAddress, serverPort);
            stream = client.GetStream();
            UnityEngine.Debug.Log("Connected to server.");
        }
        catch (System.Exception e)
        {
            UnityEngine.Debug.LogError("Error connecting to server: " + e.Message);
        }
    }

    public void SendMessageToServer(string message)
    {
        try
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
            UnityEngine.Debug.Log("Sent message to server: " + message);
        }
        catch (System.Exception e)
        {
            UnityEngine.Debug.LogError("Error sending message to server: " + e.Message);
        }
    }

    public string ReceiveData()
    {
        try
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            while (true)
            {
                bytesRead = stream.Read(buffer, 0, buffer.Length);

                if (bytesRead > 0)
                {
                    string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    UnityEngine.Debug.Log("Received message from server: " + receivedMessage);
                    return receivedMessage;
                }
            }
        }
        catch (IOException e)
        {
            UnityEngine.Debug.LogError("Error receiving data from server: " + e.Message);
        }
        return null;
    }

    public void ClusterConnection()
    {
        ConnectToServer();
        string folderPath = Path.Join(Application.dataPath, "/clusteredCSV/");

        string code = "cluster|";
        string dir = Application.dataPath;
        //Debug.Log(code + dir);
        SendMessageToServer(code + dir);
    }

    public string SortConnection(string shopList, bool isSort)
    {
        ConnectToServer();
        string code;
        if (isSort)
        {
            code = "sort|";
        }
        else
        {
            code = "notsort|";
        }

        //Debug.Log(code + shopList);
        SendMessageToServer(code + shopList);

        return ReceiveData();
    }



    public void OnDestroy()
    {
        if (stream != null)
            stream.Close();

        if (client != null)
            client.Close();
    }
}
