﻿using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace YAGMRC.Mobile
{
    internal class DownloadWithJson
    {

        #region Constructor

        public DownloadWithJson(Uri baseUri)
        {
            m_BaseUri = baseUri;
        }

        #endregion

        private Uri m_BaseUri;

        public async Task<T> Execute<T>(string rest)
        {
            Uri diplomacyUri = new Uri(m_BaseUri, rest);
            using (HttpClient httpClient = new HttpClient(new NativeMessageHandler()))
            {
                Task<string> stringTask = httpClient.GetStringAsync(diplomacyUri);

                string str = await stringTask;
                return JsonConvert.DeserializeObject<T>(str);
            }
        }

    }
}
