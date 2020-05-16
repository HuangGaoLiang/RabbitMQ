using AspNetCore.RabbitMQ.MessageConsumer_02.MessageConsumer;
using System;

namespace AspNetCore.RabbitMQ.MessageConsumer_02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                #region 发布订阅模式
                PublishSubscribeConsumer.Show();
                #endregion 
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();

        }
    }
}
