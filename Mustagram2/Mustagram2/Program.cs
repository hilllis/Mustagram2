using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mustagram2
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
     
        }
        static void test()
        {

            MustagramClient client = MustagramClient.GetClient();
            // RunAsync().GetAwaiter().GetResult();
            Func<Task> runAsync = async () =>
            {
                try
                {
                    if (await client.SendLoginInfo("유동관", "1111"))
                        System.Console.WriteLine("true");
                    else System.Console.WriteLine("false");

                    String result = await client.GetPersonalDescription("유동관");
                    int like = await client.GetPostLike(1);
                    System.Console.WriteLine(result);
                    System.Console.WriteLine(like);

                    if (await client.CreatePost("lsc", "init")) System.Console.WriteLine("성공");
                    else System.Console.WriteLine("실패");

                    // PostList postList = ;
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            };
            runAsync().GetAwaiter().GetResult();
        }
    }
}
