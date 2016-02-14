using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace TSST.Client
{
    public partial class MainForm : Form
    {
        public string ServiceURI { get; set; }

        public string FacebookToken { get; set; }

        public PostResponse postResponse { get; set; }

        public User user { get; set; }

        public List<User> listOfFriends { get; set; }

        public List<ProjectViewModel> listOfProject { get; set; }

        public List<TaskViewModel> listOfTask { get; set; }

        public List<int> listOfFriendsToProject = new List<int>();

        public MainForm()
        {
            ServiceURI = "http://tsstagile.azurewebsites.net";
            FacebookToken = Properties.Settings.Default.FacebookToken;
            getAccessToken();
            InitializeComponent();
           
        }

        private async void getAccessToken()
        {
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                        { "grant_type", "facebook" },
                        { "accesstoken", Properties.Settings.Default.FacebookToken }
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(ServiceURI + "/Token", content);
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    postResponse = new JavaScriptSerializer().Deserialize<PostResponse>(responseString);
                    Properties.Settings.Default.ApiToken=postResponse.access_token;
                }
                else
                {
                    throw new Exception();
                }

            }
        }

        private async Task<string> getMethod(string URI)
        {
            string tmp;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string token = Properties.Settings.Default.ApiToken;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.GetAsync(ServiceURI + URI);
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    tmp = responseString;
                }
                else
                {
                    throw new Exception();
                }                
            }
            return tmp;
        }

        private async void getTask(string Id)
        {
            string tmp;
            tmp = await getMethod("/api/task/GetProjectTasks?projectId="+Id);
            listOfTask = new JavaScriptSerializer().Deserialize<List<TaskViewModel>>(tmp);
        }

        private async void createProject(ProjectViewModel project)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string token = Properties.Settings.Default.ApiToken;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                //ProjectViewModel p = new ProjectViewModel();
                //p.id = 1;
                //p.title = "tytul7";
                //p.description = "opis8";
                //p.startDate = System.DateTime.Today;
                //p.endDate = System.DateTime.Today;
                //p.UserIdList.Add(1);
                //p.UserIdList.Add(2);
                //p.UserIdList.Add(5);
                //p.UserIdList.Add(6);
                string serialized = new JavaScriptSerializer().Serialize(project);
                var response = await client.PostAsync(ServiceURI + "/api/project/CreateProject", new StringContent(serialized, Encoding.UTF8, "application/json"));
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception();
                }
            }
        }

        private async void createTask(TaskViewModel task, string projectId)
        {

            //TaskViewModel tmp = new TaskViewModel();
            //tmp.Id = 2;
            //tmp.Title = "testowy tytul2";
            //tmp.Description = "testowy opis2";
            //tmp.CompleteDate = System.DateTime.Today;
            //tmp.StartDate = System.DateTime.Today;
            //tmp.CreationDate = System.DateTime.Today;
            //tmp.State = TaskState.InProgress;
            //tmp.UserId = 3;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string token = Properties.Settings.Default.ApiToken;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                string serialized = new JavaScriptSerializer().Serialize(task);
                var response = await client.PostAsync(ServiceURI + "/api/task/CreateTask?projectId="+projectId, new StringContent(serialized, Encoding.UTF8, "application/json"));        
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception();
                }
            }

        }

        private async void deleteProject(string Id)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string token = Properties.Settings.Default.ApiToken;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.DeleteAsync(ServiceURI+"/api/project/DeleteProject?id=" +Id);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        private async void getProfile()
        {
            string tmp;
            tmp = await getMethod("/api/user/getprofile");
            user = new JavaScriptSerializer().Deserialize<User>(tmp);
        }

        private async void getListOfFriends()
        {
            string tmp;
            tmp = await getMethod("/api/user/GetFriends");
            listOfFriends = new JavaScriptSerializer().Deserialize<List<User>>(tmp);
        }

        private async void getListOfProject()
        {
            string tmp;
            tmp = await getMethod("/api/project/GetMyProjects");
            listOfProject = new JavaScriptSerializer().Deserialize<List<ProjectViewModel>>(tmp);
        }

        private async void deleteTask(string taskId)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string token = Properties.Settings.Default.ApiToken;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.DeleteAsync(ServiceURI + "/api/task/DeleteTask?taskId=" + taskId);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        private async void setStateInProgress(string taskId)
        {
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string token = Properties.Settings.Default.ApiToken;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.PostAsync(ServiceURI + "/api/task/SetStateInProgress?taskId="+taskId, null);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception();
                }
            }
        }

        private async void setStateComplete(string taskId)
        {
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string token = Properties.Settings.Default.ApiToken;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.PostAsync(ServiceURI + "/api/task/SetStateComplete?taskId="+taskId, null);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception();
                }
            }
        } 

        private async void button1_Click(object sender, EventArgs e)
        {
            //   deleteProject("6");
            createTask(null, "7");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string tmp;
            tmp=await getMethod("/api/user/getprofile");
            user = new JavaScriptSerializer().Deserialize<User>(tmp);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
           
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            string tmp;
            tmp = await getMethod("/api/project/GetMyProjects");
            listOfProject = new JavaScriptSerializer().Deserialize <List< ProjectViewModel >> (tmp);
            int m = 7;
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            getTask("7");
           // createProject();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setStateComplete("2");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setStateInProgress("2");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            deleteTask("2");
        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            ProjectViewModel p = new ProjectViewModel();
            DateTime startDate = DateTime.Now;
            
            //createProject()
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void showFreindsButton_Click(object sender, EventArgs e)
        {
            string tmp;
            tmp = await getMethod("/api/user/GetFriends");
            listOfFriends = new JavaScriptSerializer().Deserialize<List<User>>(tmp);
            List<string> usersData = new List<string>();
            List<string> data = new List<string>();
            string name;
            string surname;

            foreach (User user in listOfFriends)
            {
                name = user.FirstName;
                surname = user.LastName;
                data.Add(name+" "+surname);
            }
            friendsListBox.DataSource = data;
        }
    }
}
