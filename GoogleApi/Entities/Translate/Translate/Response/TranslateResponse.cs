﻿using System.Runtime.Serialization;
using GoogleApi.Entities.Common;

namespace GoogleApi.Entities.Translate.Translate.Response
{
    /// <summary>
    /// Translate Response.
    /// </summary>
    [DataContract]
    public class TranslateResponse : BaseResponse
    {
        /// <summary>
        /// Container for the translated results.
        /// </summary>
        [DataMember(Name = "data")]
        public virtual Data Data { get; set; }
    }
}