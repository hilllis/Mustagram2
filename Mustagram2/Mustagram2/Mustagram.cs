using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Threading.Tasks;

namespace Mustagram2
{
    public class MustagramClient
    {
        private static HttpClient client = GenrateClient();
        private MustagramClient() { }
        private static HttpClient GenrateClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:3000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );
            return client;
        }
        public static HttpClient GetClient() { return client; }
        public static async Task<bool> UploadFilesAsync(string[] filePaths)
        {
            // 참고 링크
            // https://stackoverflow.com/questions/12968138/how-to-upload-a-file-in-window-forms
            // https://stackoverflow.com/questions/57690968/how-to-post-two-files-at-once-to-an-api-in-windows-forms-c-sharp
            var multiFormDataContent = new MultipartFormDataContent();

            foreach (string path in filePaths)
            {
                Console.WriteLine(path);

                FileStream fs = File.OpenRead(path);

                var streamContent = new StreamContent(fs);
                var fileContent = new ByteArrayContent(await streamContent.ReadAsByteArrayAsync());
                multiFormDataContent.Add(fileContent, "files", Path.GetFileName(path));
            }
            var response = await client.PostAsync("/file/upload", multiFormDataContent);
            return response.IsSuccessStatusCode;
        }

        // public static async Task<UserInfomation> GetProductAsync(string path)
        // {
        //   UserInfomation info = null;
        //   HttpResponseMessage response = await client.GetAsync(path);
        //   if (response.IsSuccessStatusCode)
        //     info = await response.Content.ReadAsAsync<UserInfomation>();

        //   return info;
        // }

        public static async Task<string> SendUserPersonalInfo(string userId, string userName, string sex,
      string intro,
      string birthday
    )
        {
            var personalInfo = new
            {
                id = userId,
                name = userName,
                sex = sex,
                intro = intro,
                birthday = birthday
            };
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "/user/personal/save", personalInfo
            );
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public static async Task<string> SendUserModifiedPersonalInfo(
          string userId,
          string intro
        )
        {
            var personalInfo = new
            {
                id = userId,
                intro = intro,
            };
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "/user/personal/modify", personalInfo
            );
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public static async Task<string> SendLoginInfo(string userId, string userPassword)
        {
            var loginInfo = new
            {
                id = userId,
                password = userPassword
            };
            HttpResponseMessage response = await client.PostAsJsonAsync("/user/login", loginInfo);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> SendSignInInfo(string userId, string userPassword)
        {
            var signInInfo = new
            {
                id = userId,
                password = userPassword
            };
            HttpResponseMessage response = await client.PostAsJsonAsync("/user/sign-in", signInInfo);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        public static async Task<string> SendFollowRequest(string myId, string friendId)
        {
            var followRequest = new
            {
                id = myId,
                friendId = friendId
            };
            HttpResponseMessage response = await client.PostAsJsonAsync("/user/follow", followRequest);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        public static async Task<string> SendUnfollowRequest(string myId, string friendId)
        {
            var followRequest = new
            {
                id = myId,
                friendId = friendId
            };
            HttpResponseMessage response = await client.PostAsJsonAsync("/user/unfollow", followRequest);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        public static async Task<String> GetStringAsync(string path)
        {
            string word = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
                word = await response.Content.ReadAsStringAsync();

            return word;
        }
    }
}