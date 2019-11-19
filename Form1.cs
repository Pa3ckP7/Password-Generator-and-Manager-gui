using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwords_gui
{
    public partial class Form1 : Form
    {
        static string Filters_directory = @"Saved_data\Filters";
        static string Passwords_directory = @"Saved_data\Passwords";
        static string[] Filters;
        static string[] Passwords;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Filters_directory);
            Directory.CreateDirectory(Passwords_directory);
            Filters = Directory.GetFiles(Filters_directory);
            for (int i = 0; i < Filters.Length; i++) 
            {

                Filters[i] = Filters[i].Replace(".txt", "");
                Filters[i] = Filters[i].Replace($@"{Filters_directory}\", "");
            }
            FilterSelect.Items.AddRange(Filters);
            Passwords = Directory.GetFiles(Passwords_directory);
            for (int i = 0; i < Passwords.Length; i++)
            {
                Passwords[i] = Passwords[i].Replace($@"{Passwords_directory}\", "");
            }
            NameSelect.Items.AddRange(Passwords);
        }

        private void GenPassButton_Click(object sender, EventArgs e)
        {
            if (GenKeyText.Text.Trim().Length != 0)
            {
                if (GenNameText.Text.Trim().Length != 0)
                {
                    if (!File.Exists($@"{Passwords_directory}\{GenNameText.Text}"))
                    {
                        if (File.Exists($@"{Filters_directory}\{FilterSelect.Text}.txt"))
                        {
                            PassGenManagr.Generate(GenNameText.Text, Convert.ToInt32(PasswordLengthText.Text), FilterSelect.Text, GenKeyText.Text);
                            MessageBox.Show($"Created password wtih identifier {GenNameText.Text}" +
                                $" of length {PasswordLengthText.Text} using filter {PasswordLengthText.Text}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NameSelect.Items.Add(GenNameText.Text);
                            GenNameText.Text = "";
                            PasswordLengthText.Text = "";
                            GenKeyText.Text = "";
                           
                        }
                        else
                        {
                            MessageBox.Show("Filter is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password with that name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password name is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Key is invalid", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenFiltrButton_Click(object sender, EventArgs e)
        {
            if (CrtFilterNameText.Text.Trim().Length != 0)
            {
                Form2 f2 = new Form2(CrtFilterNameText.Text);
                f2.Show();
                FilterSelect.Items.Add(CrtFilterNameText.Text);
                CrtFilterNameText.Text = "";
            }
            else 
            {
                MessageBox.Show("Filter Name invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RetPassButton_Click(object sender, EventArgs e)
        {
            String passName=File.ReadAllText($@"{Passwords_directory}\{NameSelect.Text}");
            string password=Encrypt.DecryptString(passName, RetKeyText.Text);
            PasswordText.Text = password;
            NameSelect.Text = "";
            RetKeyText.Text = "";
        }

        private void FilterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] charss = File.ReadAllLines($@"{Filters_directory}\{FilterSelect.Text}.txt");
                string availablechars = "";
                foreach (string str in charss)
                {
                    availablechars += $"{str}, ";
                }
                FilterSymblText.Text = availablechars;
            }
            catch (Exception)
            {
                FilterSymblText.Text = "";
            }
        }
    }
}
