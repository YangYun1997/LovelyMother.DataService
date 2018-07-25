using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LovelyMother.DataService.model
{

        /// <summary>
        /// 朋友。
        /// </summary>
    public class FriendTask
    {
            /// <summary>
            /// 朋友ID。
            /// </summary>
            [JsonProperty("friendid")]
            public int FriendId { get; set; }

            /// <summary>
            /// 用户ID。
            /// </summary>

            public string UserId { get; set; }


            /// <summary>
            /// 时间。
            /// </summary>

            public int Data { get; set; }

            /// <summary>
            /// 开始时间。
            /// </summary>
  
            public string Begin { get; set; }

            /// <summary>
            /// 结束时间。
            /// </summary>

            public string End { get; set; }

            /// <summary>
            /// 总时间。
            /// </summary>

            public int TotalTime { get; set; }

            /// <summary>
            /// 预期时间。
            /// </summary>

            public int DefaultTime { get; set; }

        /// <summary>
        /// 学习期间描述。
        /// </summary>

        public string Introduction { get; set; }
    }

}
