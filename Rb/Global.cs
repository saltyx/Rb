using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaBlock
{
    class Global
    {
        public delegate void f(string str);
        public delegate string return_position();//接收到消息之后回调返回自己的位置
        public delegate void f_score(int s);
        public delegate int return_score();

        public static f_score callback_score;//get score
        public static return_score return_s;//return score

        public static f callback;

        public static f server_callback;

        public static return_position pos_callback;

        public static return_position posClient_callback;

        
    }
}
