using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace SmartDisplay.Domotique
{
    public class Class1
    {
       public static void Test()
        {
            // create client instance 
            MqttClient client = new MqttClient("192.168.0.147");

            // register to message received 
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);

            // subscribe to the topic "/home/temperature" with QoS 2 
            client.Subscribe(new string[] { "/home/#", "/set/home/#" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        }

        static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string message = Encoding.UTF8.GetString(e.Message);

            if (e.Topic.StartsWith("/set"))
            {
                Debug.WriteLine("{0} : {1}", e.Topic, message);                
            }
            else
            {
                // handle message received 
                Debug.WriteLine("{0} : {1}", e.Topic, message);
            }
        }
        }
}
