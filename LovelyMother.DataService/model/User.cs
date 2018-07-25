using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LovelyMother.DataService.model
{
/// <summary>
        /// 用户。
        /// </summary>
    public class User
    {
            /// <summary>
            /// 主键。
            /// </summary>
            [JsonProperty("id")]
            public int Id { get; set; }

            /// <summary>
            /// 用户名。
            /// </summary>

            public string UserName { get; set; }


            /// <summary>
            /// 密码。
            /// </summary>

            public string PassWord { get; set; }

            /// <summary>
            /// 使用总时间。
            /// </summary>
            [JsonProperty("totaltime")]
            public string  TotalTime { get; set; }



            /// <summary>
            /// 头像。
            /// </summary>
            [JsonProperty("avatar")]
            public string Avatar { get; set; }


        }
    }

