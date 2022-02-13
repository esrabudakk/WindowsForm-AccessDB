using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace A5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Esra\\Desktop\\Quizes.accdb");

        List <Question> allQuestions;

        List<Question> selectedQuestions;
        int percentage;
        int currentQuestion = 0;
        int score ;
        string selectedRadioBtn;

        System.Timers.Timer t;
        int h, m = 5, s = 60;

        private void Form2_Load(object sender, EventArgs e)
        {


            allQuestions = new List<Question>();
            selectedQuestions = new List<Question>();
            //String queryString = "select UserName , Password from Student where UserName ='" + txtUserName.Text + "' AND Password ='" + txtPassword.Text+"';";
            string queryString = $"select * from Question ;";
        
            OleDbCommand cmd = new OleDbCommand(queryString, con);

            cmd.Connection = con;

            con.Open();

            //  OleDbDataReader reader = cmd.ExecuteReader();


            //while( reader.Read())
            //// {
            //     for(int i = 1; i< 3; i++)
            //     {


            //     Question q = new Question();

            //     string a = reader.GetInt32(0).ToString();
            //     string a2 = reader.GetString(1);
            //     lblQT.Text = a2;
            //         //string a21 = reader.GetString(2);
            //         //string a22 = reader.GetString(3);
            //         //string a23 = reader.GetString(4);
            //         //string a24 = reader.GetString(5);
            //     }
            //}

         


            using (OleDbDataReader reader = cmd.ExecuteReader())
            {

               
                while (reader.Read())
                {
                    Question question = new Question
                    {
                        QuestionID = reader.GetInt32(0),
                        QuestionText = reader["QuestionText"].ToString(),

                        Answer1 = reader["Answer1"].ToString(),
                        Answer2 = reader["Answer2"].ToString(),
                        Answer3 = reader["Answer3"].ToString(),
                        Answer4 = reader["Answer4"].ToString(),
                        CorrectAnswer = reader["CorrectAnswer"].ToString(),

                    };

                    allQuestions.Add(question);


                }
            


                reader.Close();
                con.Close();
            }
             Random rand = new Random();
            for (int i = 0; i < 3; i++) {
                    int randomNumber = rand.Next(1, allQuestions.Count());
                    Question selectedQuestion = allQuestions[randomNumber];
                   
                    selectedQuestions.Add(selectedQuestion);
                allQuestions = allQuestions.Where(x => x.QuestionID != selectedQuestion.QuestionID).ToList();

               
            }


            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            t.Start();

            questionText.Text = selectedQuestions[0].QuestionText;
            rdOption.Text = selectedQuestions[currentQuestion].Answer1;
            rdOption2.Text = selectedQuestions[currentQuestion].Answer2;
            rdOption3.Text = selectedQuestions[currentQuestion].Answer3;
            rdOption4.Text = selectedQuestions[currentQuestion].Answer4;


        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s -= 1;
                if (s == 60)
                {
                    s = 0;
                    m -= 1;

                }
                if (m == 60)
                {
                    m = 0;
                    h -= 1;

                }
                txtResult.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                if (m == 0 && s == 0)
                {
                    this.Close();
                }
            }));
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {

         

            if (selectedRadioBtn.Equals(selectedQuestions[currentQuestion].CorrectAnswer))
            {
                score++;
              
            }
            if(currentQuestion == 2 )
            {
                // work out the percentage here

                percentage = (int)Math.Round((double)(100 * score) / selectedQuestions.Count());

                MessageBox.Show("Quiz Ended" + Environment.NewLine +
                                "You have answered " + score + " questions correcly" + Environment.NewLine +
                                "Your total percentage is " + percentage + " %" + Environment.NewLine);

                //puan
               this.Close();
            }
            else
            {

                currentQuestion++;

                questionText.Text = selectedQuestions[currentQuestion].QuestionText;
                rdOption.Text = selectedQuestions[currentQuestion].Answer1;
                rdOption2.Text = selectedQuestions[currentQuestion].Answer2;
                rdOption3.Text = selectedQuestions[currentQuestion].Answer3;
                rdOption4.Text = selectedQuestions[currentQuestion].Answer4;

                
            }
        }
          

        private void rdOption_CheckedChanged(object sender, EventArgs e)
        {
          
            selectedRadioBtn = rdOption.Text;
            
        }

        private void rdOption2_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadioBtn = rdOption2.Text;
        }

        private void rdOption3_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadioBtn = rdOption3.Text;
        }

        private void rdOption4_CheckedChanged(object sender, EventArgs e)
        {
            selectedRadioBtn = rdOption4.Text;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            lblUser.Text = "user interaction is captured at:";
            lblTime.Text = DateTime.Now.ToLongTimeString();
            
        }
    }
}
