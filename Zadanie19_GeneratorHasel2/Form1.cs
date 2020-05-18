using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie19_GeneratorHasel2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int givenNumberOfCharactersInPassword = 0;
        public int givenNumberOfPasswords = 1;
        public static byte givenComplexityLevel = 1;

        List<byte> ListOfSpecificCharacters1 = CreatingListOfSpecificCharacters(1);
        List<byte> ListOfSpecificCharacters2 = CreatingListOfSpecificCharacters(2);
        List<byte> ListOfSpecificCharacters3 = CreatingListOfSpecificCharacters(3);
        List<byte> ListOfSpecificCharacters4 = CreatingListOfSpecificCharacters(4);


        private void button2_Click(object sender, EventArgs e)
        {

            

            givenNumberOfCharactersInPassword = (Int32)numUpDownPasswordLength.Value;
            givenNumberOfPasswords = (Int32)numUpDownHowManyPasswords.Value;

            if (rbtn_complexity1.Checked)
            {
                givenComplexityLevel = 1;
            }
            if (rbtn_complexity2.Checked)
            {
                givenComplexityLevel = 2;
            }
            if (rbtn_complexity3.Checked)
            {
                givenComplexityLevel = 3;
            }
            if (rbtn_complexity4.Checked)
            {
                givenComplexityLevel = 4;
            }

            List<byte> ListOfPossibleNumbers = CreatingListOfPossibleNumbers(givenComplexityLevel);


            while (givenNumberOfPasswords > 0)
            {
                // wszystko dalej ze starej aplikcji konsolowej

                char[] newPassword = new char[givenNumberOfCharactersInPassword];

                int randomNumberIndex = 0;

                if (givenComplexityLevel > 0)
                {

                    int ASCIICodeNumber = ListOfSpecificCharacters1[RandomNumber(ListOfSpecificCharacters1.Count)];
                    char characterInPassword = (char)ASCIICodeNumber;
                    newPassword[RandomNumber(givenNumberOfCharactersInPassword)] = characterInPassword;
                }
                if (givenComplexityLevel > 1)
                {
                    int ASCIICodeNumber = ListOfSpecificCharacters2[RandomNumber(ListOfSpecificCharacters2.Count)];
                    char characterInPassword = (char)ASCIICodeNumber;

                    bool characterAdded = false;
                    do
                    {
                        randomNumberIndex = RandomNumber(givenNumberOfCharactersInPassword);
                        if (newPassword[randomNumberIndex] == '\0')
                        {
                            newPassword[randomNumberIndex] = characterInPassword;
                            characterAdded = true;
                        }
                    } while (characterAdded == false);
                }
                if (givenComplexityLevel > 2)
                {
                    int ASCIICodeNumber = ListOfSpecificCharacters3[RandomNumber(ListOfSpecificCharacters3.Count)];
                    char characterInPassword = (char)ASCIICodeNumber;

                    bool characterAdded = false;
                    do
                    {
                        randomNumberIndex = RandomNumber(givenNumberOfCharactersInPassword);
                        if (newPassword[randomNumberIndex] == '\0')
                        {
                            newPassword[randomNumberIndex] = characterInPassword;
                            characterAdded = true;
                        }
                    } while (characterAdded == false);
                }
                if (givenComplexityLevel > 3)
                {
                    int ASCIICodeNumber = ListOfSpecificCharacters4[RandomNumber(ListOfSpecificCharacters3.Count)];
                    char characterInPassword = (char)ASCIICodeNumber;

                    bool characterAdded = false;
                    do
                    {
                        randomNumberIndex = RandomNumber(givenNumberOfCharactersInPassword);
                        if (newPassword[randomNumberIndex] == '\0')
                        {
                            newPassword[randomNumberIndex] = characterInPassword;
                            characterAdded = true;
                        }
                    } while (characterAdded == false);
                }



                for (int i = 0; i < givenNumberOfCharactersInPassword; i++)
                {
                    if (newPassword[i] == '\0')
                    {
                        int ASCIICodeNumber = ListOfPossibleNumbers[RandomNumber(ListOfPossibleNumbers)];
                        char characterInPassword = (char)ASCIICodeNumber;

                        newPassword[i] = characterInPassword;
                    }


                }


                string stringNewPassword = new string(newPassword);

                // wszystko dotąd ze starej aplikcji konsolowej

                if (!listBox_ListOfPasswords.Items.Contains(stringNewPassword))  //zabezpieczenie przed powtórzeniem hasła
                {

                    listBox_ListOfPasswords.Items.Add(stringNewPassword);
                    listBox_ListOfPasswords.TopIndex = listBox_ListOfPasswords.Items.Count - 1;
                   // Focus(listBox_ListOfPasswords[listBox_ListOfPasswords.Count - 1]);
                   // listBox_ListOfPasswords.Focus() = listBox_ListOfPasswords[listBox_ListOfPasswords.Count - 1];

                    givenNumberOfPasswords--;
                }
            }
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);
        private static int RandomNumber(List<byte> ListOfPossibleNumbers)
        {

            return random.Next(ListOfPossibleNumbers.Count);

        }

        private static int RandomNumber(int numberOfCharactersInPassword)
        {

            return random.Next(0, numberOfCharactersInPassword);

        }


        public static List<byte> CreatingListOfPossibleNumbers(int complexityLevel)
        {
            List<byte> ListOfPossibleNumbers = new List<byte>();
            byte ASCIICodeNumber;

            if (complexityLevel > 0)
            {
                for (ASCIICodeNumber = 48; ASCIICodeNumber < 58; ASCIICodeNumber++)
                {
                    ListOfPossibleNumbers.Add(ASCIICodeNumber);
                }


            }
            if (complexityLevel > 1)
            {
                for (ASCIICodeNumber = 97; ASCIICodeNumber < 123; ASCIICodeNumber++)
                {
                    ListOfPossibleNumbers.Add(ASCIICodeNumber);
                }

            }
            if (complexityLevel > 2)
            {
                for (ASCIICodeNumber = 65; ASCIICodeNumber < 91; ASCIICodeNumber++)
                {
                    ListOfPossibleNumbers.Add(ASCIICodeNumber);
                }
            }
            if (complexityLevel > 3)
            {
                ListOfPossibleNumbers.Clear();
                for (ASCIICodeNumber = 33; ASCIICodeNumber < 127; ASCIICodeNumber++)
                {
                    ListOfPossibleNumbers.Add(ASCIICodeNumber);
                }

            }

            return ListOfPossibleNumbers;
        }


        public static List<byte> CreatingListOfSpecificCharacters(int givenComplexityLevel)
        {
            List<byte> ListOfSpecificCharacter = new List<byte>();
            byte ASCIICodeNumber;

            switch (givenComplexityLevel)
            {
                case 1:
                    for (ASCIICodeNumber = 48; ASCIICodeNumber < 58; ASCIICodeNumber++)
                    {
                        ListOfSpecificCharacter.Add(ASCIICodeNumber);
                    }
                    break;
                case 2:
                    for (ASCIICodeNumber = 97; ASCIICodeNumber < 123; ASCIICodeNumber++)
                    {
                        ListOfSpecificCharacter.Add(ASCIICodeNumber);
                    }
                    break;
                case 3:
                    for (ASCIICodeNumber = 65; ASCIICodeNumber < 91; ASCIICodeNumber++)
                    {
                        ListOfSpecificCharacter.Add(ASCIICodeNumber);
                    }
                    break;
                case 4:
                    for (ASCIICodeNumber = 33; ASCIICodeNumber < 48; ASCIICodeNumber++)
                    {
                        ListOfSpecificCharacter.Add(ASCIICodeNumber);
                    }
                    for (ASCIICodeNumber = 58; ASCIICodeNumber < 65; ASCIICodeNumber++)
                    {
                        ListOfSpecificCharacter.Add(ASCIICodeNumber);
                    }
                    for (ASCIICodeNumber = 91; ASCIICodeNumber < 97; ASCIICodeNumber++)
                    {
                        ListOfSpecificCharacter.Add(ASCIICodeNumber);
                    }
                    for (ASCIICodeNumber = 123; ASCIICodeNumber < 127; ASCIICodeNumber++)
                    {
                        ListOfSpecificCharacter.Add(ASCIICodeNumber);
                    }
                    break;
                default:
                    break;
            }


            return ListOfSpecificCharacter;
        }

        private void rbtn_complexity_Click(object sender, EventArgs e)
        {
            btn_PasswordGenerator.Enabled = true;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            numUpDownPasswordLength.Value = 4;
            numUpDownHowManyPasswords.Value = 1;
            btn_PasswordGenerator.Enabled = false;
            listBox_ListOfPasswords.Items.Clear();

            rbtn_complexity1.Checked = false;
            rbtn_complexity2.Checked = false;
            rbtn_complexity3.Checked = false;
            rbtn_complexity4.Checked = false;
        }

        private void listBox_ListOfPasswords_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(listBox_ListOfPasswords.SelectedItem);
            MessageBox.Show("Password copied to clipboard", "Success!");
        }
    }

    
}
