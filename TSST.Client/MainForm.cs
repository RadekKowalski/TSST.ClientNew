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

        public User user { get; set; }

        public List<User> listOfFriends { get; set; }

        public List<ProjectViewModel> listOfProject { get; set; }

        public List<TaskViewModel> listOfTask { get; set; }

        public List<int> listOfFriendsToProject = new List<int>();
        public List<string> listOfFriendsIDs = new List<string>();
        private List<string> fileList = new List<string>();

        public MainForm()
        {
            ServiceURI = "http://tsstagile.azurewebsites.net";
            FacebookToken = Properties.Settings.Default.FacebookToken;
            InitializeComponent();
           
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

        private async Task getTask(string Id)
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

        private async Task deleteProject(string Id)
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

        private async Task getProfile()
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

        private async Task getListOfProject()
        {
            string tmp;
            tmp = await getMethod("/api/project/GetMyProjects");
            listOfProject = new JavaScriptSerializer().Deserialize<List<ProjectViewModel>>(tmp);
        }

        private async Task deleteTask(string taskId)
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
        private async void sendFile(string Path, string description, int taskID)
        {
            var fileName = Path.Split('\\').Last();
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Put, "http://tsstagile.azurewebsites.net/api/task/AddFile");
            byte[] content = System.IO.File.ReadAllBytes(Path);
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string token = Properties.Settings.Default.ApiToken;
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            requestMessage.Headers.Add("TaskId", taskID.ToString());
            requestMessage.Headers.Add("FileName", fileName);
            requestMessage.Headers.Add("FileDescription", description);
            requestMessage.Content = new ByteArrayContent(content);
            HttpResponseMessage response = await httpClient.SendAsync(requestMessage);
            string responseAsString = await response.Content.ReadAsStringAsync();
        }


        private async void createProjectButton_Click(object sender, EventArgs e)
        {
            await getProfile();
            listOfFriendsToProject.Add(user.Id);
            listOfFriendsToProject = listOfFriendsToProject.Distinct().ToList<int>();
            
            DateTime startDate = DateTime.Now;
            ProjectViewModel project = new ProjectViewModel(1, titleTextBox.Text, descriptionTextBox.Text, DateTime.Now, dateTimePicker1.Value, listOfFriendsToProject);
            createProject(project);
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
            

            foreach (User user in listOfFriends)
            {
                var name = user.FirstName;
                var surname = user.LastName;
                var ID = user.Id;
                data.Add(ID+" "+name+" "+surname);
                listOfFriendsIDs.Add(ID.ToString());
            }
            friendsListBox.DataSource = data;
        }

        public List<string> usersToProject = new List<string>();
        private void adFriendButton_Click(object sender, EventArgs e)
        {
            var selectedID = Convert.ToInt32(friendsListBox.SelectedItem.ToString().Split(' ')[0]);
            listOfFriendsToProject.Add(selectedID);
            usersToProject.Add(friendsListBox.SelectedItem.ToString());
            selectedFriendsListBox.DataSource = null;
            selectedFriendsListBox.SelectedItem = null;
            selectedFriendsListBox.DataSource = usersToProject;
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                selectedFileTextBox.Text = openFileDialog1.FileName;
            }

        }

        private async void createTaskButton_Click(object sender, EventArgs e)
        {
            await getProfile();
            var task = new TaskViewModel(taskTitleTextBox.Text, taskDescriptionTextBox.Text,DateTime.Now,user.Id);
            var pID = (int)projectsAvailableComboBox.SelectedValue;
            createTask(task, pID.ToString());
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            await getListOfProject();
            projectsAvailableComboBox.DataSource = null;
            projectsAvailableComboBox.DataSource = listOfProject;
            projectsAvailableComboBox.DisplayMember = "title";
            projectsAvailableComboBox.ValueMember = "id";
        }

        private async void projectsAvailableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            projectsAvailableComboBox.ValueMember = "id";
            var pID = (int)projectsAvailableComboBox.SelectedValue;
            await getTask(pID.ToString());
            updateTaskComboBox.DataSource = null;
            updateTaskComboBox.DataSource = listOfTask;
            updateTaskComboBox.DisplayMember = "title";
            updateTaskComboBox.ValueMember = "id";
        }

        private async void button2_Click_1(object sender, EventArgs e)
        {
            await getListOfProject();
            fileProjectComboBox.DataSource = listOfProject;
            fileProjectComboBox.DisplayMember = "title";
            fileProjectComboBox.ValueMember = "id";
        }

        private async void fileProjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileProjectComboBox.ValueMember = "id";
            var pID = (int)fileProjectComboBox.SelectedValue;
            await getTask(pID.ToString());
            fileTaskComboBox.DataSource = null;
            fileTaskComboBox.DataSource = listOfTask;
            fileTaskComboBox.DisplayMember = "title";
            fileTaskComboBox.ValueMember = "id";
        }

        private void attachFileButton_Click(object sender, EventArgs e)
        {
            fileTaskComboBox.ValueMember = "id";
            sendFile(selectedFileTextBox.Text, fileDescriptionTextBox.Text , (int)fileTaskComboBox.SelectedValue);
        }

        private void udateTaskButton_Click(object sender, EventArgs e)
        {
            if (updateTaskComboBox.Items.Count!=0)
            {
                if (radioButton1.Checked)
                    setStateInProgress(updateTaskComboBox.SelectedValue.ToString());
                else if (radioButton2.Checked)
                    setStateComplete(updateTaskComboBox.SelectedValue.ToString()); 
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await deleteTask(updateTaskComboBox.SelectedValue.ToString());
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await getListOfProject();
            deletingProjectComboBox.DataSource = null;
            deletingProjectComboBox.DataSource = listOfProject;
            deletingProjectComboBox.DisplayMember = "title";
            deletingProjectComboBox.ValueMember = "id";
        }

        private async void deleteProjectButton_Click(object sender, EventArgs e)
        {
            var pID = deletingProjectComboBox.SelectedValue;
            await deleteProject(pID.ToString());
        }
    }
}
