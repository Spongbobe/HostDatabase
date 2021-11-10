using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestIQ.UControls
{
    /// <summary>
    /// Interaction logic for DetailQuestionUControl.xaml
    /// </summary>
    public partial class DetailQuestionUControl : UserControl
    {
        Grid _grid;
        Models.QuestionModel _model;
        DataAcces.ReviewQuestionAccess questionAccess;

        public DetailQuestionUControl(Grid grid,Models.QuestionModel question)
        {
            InitializeComponent();
            _grid = grid;
            _model = question;
            UpdateInfo(question);
            UpdateReviewQuestionHistory();

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _grid.Children.Remove(this);
        }

        private void UpdateInfo(Models.QuestionModel question)
        {
            questionTb.Text = question.Question;
            answerTb.Text = question.Answer;
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            if(scoreTb.Text.Length >0)
            {
                AddReviewQuestion(new Models.ReviewQuestionModel() { ReviewTime = DateTime.Now,Score = int.Parse(scoreTb.Text),TeacherName = "rith",QuestionModel =_model});
                UpdateReviewQuestionHistory();
            }
        }
        //Update
        private  void UpdateReviewQuestionHistory()
        {
            questionAccess = new DataAcces.ReviewQuestionAccess();
            listHistory.ItemsSource =  questionAccess.LoadReviewQuestion();


        }
        private async void AddReviewQuestion(Models.ReviewQuestionModel reviewQ)
        {
            DataAcces.ReviewQuestionAccess questionAccess = new DataAcces.ReviewQuestionAccess();
            await questionAccess.AddQuestion(reviewQ);
        }


    }
}
