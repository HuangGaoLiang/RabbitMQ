using AspNetCore.RabbitMQ.MessageConsumer_01.MessageConsumer;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.RabbitMQ.MessageConsumer_01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region 生产者消费者
                //ProductionConsumer.Show();
                #endregion

                #region 多生产消费者
                //Task.Run(() => { MultiProductionConsumer.Show01(); });
                //Task.Run(() => { MultiProductionConsumer.Show02(); });
                //Task.Run(() => { MultiProductionConsumer.Show03(); });
                #endregion

                #region 互为生产消费者
                //Task.Run(() => { MutualProductionConsumer.ShowProductio(); });
                //Task.Run(() => { MutualProductionConsumer.ShowConsumer(); });
                #endregion

                #region 发布订阅模式
                //PublishSubscribeConsumer.Show();
                #endregion


                #region 秒杀
               SeckillConsumer.Show();
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
