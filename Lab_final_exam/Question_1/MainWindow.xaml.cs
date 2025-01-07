﻿
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace QuestionnaireApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadQuestions();
        }

        // Define the Question class to represent the data
        public class Question
        {
            public int No { get; set; }
            public string QuestionText { get; set; }
            public string Options { get; set; }
            public string CorrectAnswer { get; set; }
            public int Marks { get; set; }
            public int TimeLimit { get; set; }
            public string Topic { get; set; }
            public string Difficulty { get; set; }
        }

        // Method to load questions from the database into the DataGrid
        private void LoadQuestions()
        {
            List<Question> questions = new List<Question>();

            // Connection string from app.config
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QuizAppConnection"].ConnectionString;

            // SQL query to retrieve data from the 'questions' table
            string query = "SELECT Id, QuestionText, Options, CorrectAnswer, Marks, TimeLimit, Topic, Difficulty FROM questions";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Add each question to the list
                        questions.Add(new Question
                        {
                            No = reader.GetInt32(0), // ID
                            QuestionText = reader.GetString(1),
                            Options = reader.GetString(2),
                            CorrectAnswer = reader.GetString(3),
                            Marks = reader.GetInt32(4),
                            TimeLimit = reader.GetInt32(5),
                            Topic = reader.GetString(6),
                            Difficulty = reader.GetString(7)
                        });
                    }

                    // Bind the list of questions to the DataGrid
                    QuestionsDataGrid.ItemsSource = questions;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}

