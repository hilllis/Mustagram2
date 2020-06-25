using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Threading.Tasks;

namespace Mustagram2 {
  public class MustagramClient
  {
    private static HttpClient client = GenrateClient();
    private static MustagramClient mustagramClient = new MustagramClient();
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
    public static MustagramClient GetClient() { return mustagramClient; }
    public async Task<bool> UploadFilesAsync(string[] filePaths)
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

    public async Task<bool> SendUserPersonalInfo(
      string userId,
      string userName,
      string sex,
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
      return isSuccess(await response.Content.ReadAsStringAsync());
    }
    public async Task<bool> SendUserModifiedPersonalInfo(
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
      return isSuccess(await response.Content.ReadAsStringAsync());
    }
    public async Task<bool> SendLoginInfo(string userId, string userPassword)
    {
      var loginInfo = new
      {
        id = userId,
        password = userPassword
      };
      HttpResponseMessage response = await client.PostAsJsonAsync("/user/login", loginInfo);
      response.EnsureSuccessStatusCode();

      return isSuccess(await response.Content.ReadAsStringAsync());
    }

    public async Task<bool> SendSignInInfo(string userId, string userPassword)
    {
      var signInInfo = new
      {
        id = userId,
        password = userPassword
      };
      HttpResponseMessage response = await client.PostAsJsonAsync("/user/sign-in", signInInfo);
      response.EnsureSuccessStatusCode();

      return isSuccess(await response.Content.ReadAsStringAsync());
    }
    public async Task<bool> SendFollowRequest(string myId, string friendId)
    {
      var followRequest = new
      {
        id = myId,
        friendId = friendId
      };
      HttpResponseMessage response = await client.PostAsJsonAsync("/user/follow", followRequest);
      response.EnsureSuccessStatusCode();

      return isSuccess(await response.Content.ReadAsStringAsync());
    }
    public async Task<bool> SendUnfollowRequest(string myId, string friendId)
    {
      var followRequest = new
      {
        id = myId,
        friendId = friendId
      };
      HttpResponseMessage response = await client.PostAsJsonAsync("/user/unfollow", followRequest);
      response.EnsureSuccessStatusCode();

      return isSuccess(await response.Content.ReadAsStringAsync());
    }

    public async Task<string> GetPersonalDescription(string id)
    {
      HttpResponseMessage response = await client.PostAsJsonAsync("/user/personal/get", new { id = id });
      response.EnsureSuccessStatusCode();
      return await response.Content.ReadAsStringAsync();
    }

    private class ResultType
    {
      public int like { get; set; }
    }
    public async Task<int> GetPostLike(int postNumber)
    {
      HttpResponseMessage response = await client.PostAsJsonAsync("/post/count-like", new { postNumber = postNumber });
      response.EnsureSuccessStatusCode();

      var result = await response.Content.ReadAsAsync<ResultType>();
      return result.like;
    }
    public async Task<int> GetCommentLike(int commentNumber) {
      HttpResponseMessage response = await client.PostAsJsonAsync("/comment/count-like", new { commentNumber = commentNumber });
      response.EnsureSuccessStatusCode();

      var result = await response.Content.ReadAsAsync<ResultType>();
      return result.like;
    }

    public async Task<String> GetStringAsync(string path)
    {
      string word = null;
      HttpResponseMessage response = await client.GetAsync(path);
      if (response.IsSuccessStatusCode)
        word = await response.Content.ReadAsStringAsync();

      return word;
    }

    public async Task<bool> CreatePost(string id, string content) {
      HttpResponseMessage res = await client.PostAsJsonAsync("/post/create", new {id=id, content=content});
      res.EnsureSuccessStatusCode();

      return isSuccess(await res.Content.ReadAsStringAsync());
    }

    private bool isSuccess(String result) => result == "success";
  }
}