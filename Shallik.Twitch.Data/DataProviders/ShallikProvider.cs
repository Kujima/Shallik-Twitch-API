using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shallik.Twitch.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Shallik.Twitch.Data.DataProviders
{
    public class ShallikProvider
    {
        const string FILENAME_LOGIN = "login.json";
        const string FILENAME_OAUTHTOKEN = "OauthToken.json";
        const string URL_GET_USER = "https://api.twitch.tv/helix/users?login=shallik";
        const string URL_GET_LIVE = "https://api.twitch.tv/helix/streams";

        /// <summary>
        /// objet de la class httpClient permettant d'effectuer des requête http
        /// </summary>
        private static readonly HttpClient _client = new();

        private readonly Login _login;
        private readonly OauthToken _oauthToken;

        public ShallikProvider()
        {
            // Récupération des informations présent dans le fichier login.json
            StreamReader readerLogin = new StreamReader(FILENAME_LOGIN);
            string jsonStringLogin = readerLogin.ReadToEnd();
            _login = JsonConvert.DeserializeObject<Login>(jsonStringLogin);

            // Récupération des informations présent dans le fichier OauthToken.json
            StreamReader readerOauthToken = new StreamReader(FILENAME_OAUTHTOKEN);
            string jsonStringOauthToken = readerOauthToken.ReadToEnd();
            _oauthToken = JsonConvert.DeserializeObject<OauthToken>(jsonStringOauthToken);
        }

        /// <summary>
        /// Permet de retourner l'objet utilisateur correspondant à Shallik
        /// </summary>
        /// <param name="oauthToken"></param>
        /// <returns></returns>
        public async Task<UserChannel> GetUser()
        {
            // on prépare l'entete de la requete 
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_oauthToken.token_type, _oauthToken.access_token);
            _client.DefaultRequestHeaders.Add("Client-Id", _login.client_id);

            // Execution de la requete
            HttpResponseMessage response = await _client.GetAsync(URL_GET_USER);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            // Parse en object
            DataRecipeUser data = JsonConvert.DeserializeObject<DataRecipeUser>(responseBody);
            UserChannel user = data.data.First();

            return user;
        }

        public async Task<Live> GetLive(UserChannel shallikUser)
        {
            // On prépare l'entete de la requete 
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_oauthToken.token_type, _oauthToken.access_token);
            _client.DefaultRequestHeaders.Add("Client-Id", _login.client_id);

            // Ajout des param à l'url 
            string urlGetLive = $"{URL_GET_LIVE}?user_id{shallikUser.id}";

            // Execution de la requete 
            HttpResponseMessage response = await _client.GetAsync(urlGetLive);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            // Parse en object
            DataRecipeLive data = JsonConvert.DeserializeObject<DataRecipeLive>(responseBody);
            Live live = data.data.First();

            return live;
        }
    }
}
