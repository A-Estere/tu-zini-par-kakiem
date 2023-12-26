using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ko_tu_zini_par_kakiem
{
    public partial class Form2 : Form
    {
        int qTotal = 13;
        int correcAnswer;
        int qNumber = 1;
        int scoreNum;
        public Form2()
        {
            InitializeComponent();
            setOfQuestions(qNumber);
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correcAnswer)
            {
                scoreNum++; 
            }
            if(qNumber == qTotal)
            {
                MessageBox.Show(
                    "Tests Beidzās!" + Environment.NewLine +
                    "Jūsu Rezultāts: " + scoreNum + " / " + qTotal + Environment.NewLine +
                    "Nospied Labi, lai spēlētu atkal."
                    );
                scoreNum = 0;
                qNumber = 0;
                setOfQuestions(qNumber);


            }

            qNumber++;
            setOfQuestions(qNumber);
        }
        private void setOfQuestions(int question_number)
        {
            switch (question_number)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Pukes1;
                    label1.Text = "Neindīgs augs kaķiem?";
                    btn1.Text = "Lilijas";
                    btn2.Text = "Roses";
                    btn3.Text = "Tulpes";

                    correcAnswer = 2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Krāsās;
                    label1.Text = "Kuru krāsu kaķis vislabāk redz?";
                    btn1.Text = "Zilu";
                    btn2.Text = "Baltu";
                    btn3.Text = "Dzeltanu";

                    correcAnswer = 1;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Clock_;
                    label1.Text = "Cik ilgi kaķi var atstāt vienu mājās?";
                    btn1.Text = "24 stundas";
                    btn2.Text = "12 stundas";
                    btn3.Text = "8 stundas";

                    correcAnswer = 3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Puķes_;
                    label1.Text = "Indīgs augs kaķiem?";
                    btn1.Text = "Orhidejas";
                    btn2.Text = "Narcises";
                    btn3.Text = "Naudas koks";

                    correcAnswer = 2;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.dusm;
                    label1.Text = "Kad kaķis vicina asti ir?";
                    btn1.Text = "Nokaitināts";
                    btn2.Text = "Laimīgs";
                    btn3.Text = "Greizsirdīgs";

                    correcAnswer = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Veārtrs_;
                    label1.Text = "Cik bieži jāved kaķis pie veārsta?";
                    btn1.Text = "Ik pēc diviem gadiem";
                    btn2.Text = "Ik pēc trijiem gadiem";
                    btn3.Text = "Reiz gadā";

                    correcAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.Ķemme_;
                    label1.Text = "cik bieži ir jāķemmē īsspalvains kaķis?";
                    btn1.Text = "Reizi nedēļā";
                    btn2.Text = "Katru dienu";
                    btn3.Text = "Divas reizes nedēļā";

                    correcAnswer = 1;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.Bļodā_;
                    label1.Text = "Kāda ir veselīgākā barības bļoka kaķim?";
                    btn1.Text = "Plastama";
                    btn2.Text = "Tērauda";
                    btn3.Text = "Kermikas";

                    correcAnswer = 2;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.Kaķis_;
                    label1.Text = "Cik ilgi dzīvo kaķis ?";
                    btn1.Text = "10 līdz 15 gadus";
                    btn2.Text = "9 līdz 17 gadus";
                    btn3.Text = "8 līdz 16 gadus";

                    correcAnswer = 1;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.Ēd;
                    label1.Text = "Cik daudz kaķis jābaro dienā?";
                    btn1.Text = "3";
                    btn2.Text = "4";
                    btn3.Text = "2";

                    correcAnswer = 3;
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources.Ausis_;
                    label1.Text = "Kaķa dzirdes diapazons ir?";
                    btn1.Text = "15Hz";
                    btn2.Text = "20Hz";
                    btn3.Text = "30Hz";

                    correcAnswer = 2;
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources.Guļ;
                    label1.Text = "Cik daudz stundas guļ pieaudzis kaķis?";
                    btn1.Text = "15 stundas";
                    btn2.Text = "9 stundas";
                    btn3.Text = "18 stundas";

                    correcAnswer = 1;
                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources.Box;
                    label1.Text = "Kāpēc kaķi ir apsēti ar kartona kastēm?";
                    btn1.Text = "Jo smaržo pēc kartona";
                    btn2.Text = "Jo liek kaķiem justies droši";
                    btn3.Text = "Jo izskatās dīvainas";

                    correcAnswer = 2;
                    break;

            }
        }
    }
}
