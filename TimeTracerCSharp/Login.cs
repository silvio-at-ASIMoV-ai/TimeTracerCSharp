using MySqlConnector;

namespace TimeTracerCSharp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            MySqlParameter parm = new MySqlParameter("@username", UserNameTxt.Text);
            MySqlDataReader? reader = DBHelper.SelectQuery($"SELECT * FROM `Users` WHERE `UserName` = @username", [parm]);
            if (reader != null) // only one record should be returned
            {
                reader.Read();
                string u = reader.GetString(0);
                string p = reader.GetString(1);
                if (Password.verify(u, PasswordTxt.Text, p))
                {
                    if (reader.GetInt32(2) == 1)
                    {
                        Form admin = new Admin();
                        admin.Show();
                    }
                    else
                    {
                        int empId = reader.GetInt32(3);
                        Form punchInOut = new PunchInOut(empId);
                        punchInOut.Show();
                    }
                    Hide();
                }
                else
                {
                    PasswordTxt.Clear();
                    MessageBox.Show("Accesso Negato");
                }
                reader.Close();
                DBHelper.CloseConnection();
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
