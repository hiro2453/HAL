using JevSharp.Abstractions.Models;
using JevSharp.Abstractions.Requests;
using JevSharp.Abstractions.Responses;
using JevSharp.Core.Clients;
using JevSharp.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace haiandro
{
    internal class teee
    {
        public async Task<string> Test()
        {
            var apiKey = "apikey_22392f8605e32131482690f59b25a132ecab_2c68607da5a73e4ccf9e89e5519d09927797ed8ae69e895732cb132662320320";
            var options = new JevClientOptions().UseTypeSafe(apiKey);

            using (var client = new JevClient(options))
            {
                var request = new JevRequest(
                    "現在トランプゲームのハイアンドローを行っています。場に出ているカードは1です。次にカードを引く際この数字より高いカードが出るか低いカードが出るか推測してください。",
                    new Dictionary<string, JevQuestion>
                    {
                        ["department"] = new ChoiceQuestion(
                            "次はどのような数字が来ると思いますか？",
                            new Dictionary<string, JevValue>
                            {
                                ["High"] = "高い数字が出る",
                                ["Low"] = "低い数字が出る"
                            })
                    });
                var response = await client.EvaluateAsync(request);
                return response.GetAnswer<ChoiceAnswer>("department").Choice;
            }
        }
    }
    
}
