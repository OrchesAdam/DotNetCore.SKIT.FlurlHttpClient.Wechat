﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/nlp/ner/{TOKEN} 接口的响应。</para>
    /// </summary>
    public class OpenApiNLPNERResponse : WechatOpenAIResponse<OpenApiNLPNERResponse.Types.Result[]>
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置结果类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置范围列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("span")]
                [System.Text.Json.Serialization.JsonPropertyName("span")]
                public int[] SpanList { get; set; } = default!;

                /// <summary>
                /// 获取或设置文本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public string Text { get; set; } = default!;

                /// <summary>
                /// 获取或设置范数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("norm")]
                [System.Text.Json.Serialization.JsonPropertyName("norm")]
                public object Norm { get; set; } = default!;
            }
        }
    }
}
